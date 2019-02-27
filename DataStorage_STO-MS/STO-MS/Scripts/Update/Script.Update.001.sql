:setvar DatabaseName "STO-MS"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creating [History]...';


GO
CREATE SCHEMA [History]
    AUTHORIZATION [dbo];


GO
PRINT N'Creating [Stock].[Sale]...';


GO
CREATE TABLE [Stock].[Sale] (
    [ID]           INT           NOT NULL,
    [Sold]         DATE          NOT NULL,
    [CustomerName] NVARCHAR (50) NULL,
    [IsApproved]   BIT           NOT NULL,
    [Created]      DATETIME2 (2) NOT NULL,
    [Modified]     DATETIME2 (2) NULL,
    CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
PRINT N'Creating [Stock].[SaleItem]...';


GO
CREATE TABLE [Stock].[SaleItem] (
    [SaleID]    INT           NOT NULL,
    [Order]     SMALLINT      NOT NULL,
    [ProductID] INT           NOT NULL,
    [Quantity]  INT           NOT NULL,
    [Created]   DATETIME2 (2) NOT NULL,
    [Modified]  DATETIME2 (2) NULL,
    CONSTRAINT [PK_SaleItem] PRIMARY KEY CLUSTERED ([SaleID] ASC, [Order] ASC)
);


GO
PRINT N'Creating [Stock].[FK_SaleItem_Product]...';


GO
ALTER TABLE [Stock].[SaleItem] WITH NOCHECK
    ADD CONSTRAINT [FK_SaleItem_Product] FOREIGN KEY ([ProductID]) REFERENCES [Catalog].[Product] ([ID]);


GO
PRINT N'Creating [Stock].[FK_SaleItem_Sale]...';


GO
ALTER TABLE [Stock].[SaleItem] WITH NOCHECK
    ADD CONSTRAINT [FK_SaleItem_Sale] FOREIGN KEY ([SaleID]) REFERENCES [Stock].[Sale] ([ID]);


GO
PRINT N'Creating [History].[Catalog_Component]...';


GO
CREATE TABLE [History].[Catalog_Component] (
    [HistoryID]        BIGINT         IDENTITY (1, 1) NOT NULL,
    [ID]               INT            NOT NULL,
    [ComponentTypeID]  TINYINT        NOT NULL,
    [Name]             NVARCHAR (100) NOT NULL,
    [Quantity]         INT            NOT NULL,
    [Created]          DATETIME2 (2)  NOT NULL,
    [Modified]         DATETIME2 (2)  NULL,
    [HistoryAction]    CHAR (1)       NOT NULL,
    [HistoryCreated]   DATETIME2 (2)  NOT NULL,
    [HistoryCreatedBy] NVARCHAR (256) NOT NULL,
    CONSTRAINT [PK_Catalog_Component] PRIMARY KEY CLUSTERED ([HistoryID] ASC)
);


GO
PRINT N'Creating [History].[DF_Catalog_Component_HistoryCreated]...';


GO
ALTER TABLE [History].[Catalog_Component]
    ADD CONSTRAINT [DF_Catalog_Component_HistoryCreated] DEFAULT ([Common].[GetDateTime2]()) FOR [HistoryCreated];


GO
PRINT N'Creating [History].[DF_Catalog_Component_HistoryCreatedBy]...';


GO
ALTER TABLE [History].[Catalog_Component]
    ADD CONSTRAINT [DF_Catalog_Component_HistoryCreatedBy] DEFAULT (suser_sname()) FOR [HistoryCreatedBy];


GO
PRINT N'Creating [Catalog].[TR_Component_HistoryLog]...';


GO
CREATE TRIGGER [Catalog].[TR_Component_HistoryLog]
	ON [Catalog].[Component]
	AFTER INSERT, DELETE
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [History].[Catalog_Component](
		[ID], 
		[ComponentTypeID],
		[Name],
		[Quantity],
		[Created],
		[Modified],
		[HistoryAction]
	)
	SELECT
		[ID], 
		[ComponentTypeID],
		[Name],
		[Quantity],
		[Created],
		[Modified],
		'D'
	FROM deleted
	UNION ALL
	SELECT
		[ID], 
		[ComponentTypeID],
		[Name],
		[Quantity],
		[Created],
		[Modified],
		'I'
	FROM inserted

END
GO
PRINT N'Creating [Catalog].[TR_Component_HistoryLogU]...';


GO
CREATE TRIGGER [Catalog].[TR_Component_HistoryLogU]
	ON [Catalog].[Component]
	AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [History].[Catalog_Component](
		[ID], 
		[ComponentTypeID],
		[Name],
		[Quantity],
		[Created],
		[Modified],
		[HistoryAction]
	)
	SELECT
		[ID], 
		[ComponentTypeID],
		[Name],
		[Quantity],
		[Created],
		[Modified],
		'U'
	FROM inserted
END
GO
PRINT N'Creating [Stock].[GetNextSaleID]...';


GO
CREATE FUNCTION [Stock].[GetNextSaleID]
(
)
RETURNS int
AS
BEGIN
	RETURN (
		SELECT ISNULL(MAX(ID), 0) + 1
		FROM Stock.Sale
	)
END
GO
PRINT N'Altering [Stock].[CalculateComponentStockBySupply]...';


GO
ALTER PROCEDURE [Stock].[CalculateComponentStockBySupply]
	@SupplyID int
AS
BEGIN
	SET NOCOUNT ON;

	WITH CTE_SupplyItem AS (
		SELECT
			ComponentID,
			SUM(Quantity) AS Quantity
		FROM Stock.SupplyItem
		WHERE SupplyID = @SupplyID
		GROUP BY ComponentID
	)
	MERGE Catalog.Component TRG
	USING CTE_SupplyItem SRC ON SRC.ComponentID = TRG.ID
	WHEN MATCHED THEN
		UPDATE SET
			Quantity += SRC.Quantity,
			Modified = Common.GetDateTime2()
	;

	RETURN 0
END
GO
PRINT N'Creating [Stock].[CalculateComponentStockBySale]...';


GO
CREATE PROCEDURE [Stock].[CalculateComponentStockBySale]
	@SaleID int
AS
BEGIN
	SET NOCOUNT ON;

	WITH CTE_SaleItem AS (
		SELECT
			PC.ComponentID,
			SUM(SI.Quantity) AS Quantity
		FROM Stock.SaleItem SI
			INNER JOIN Catalog.Product_Component PC ON PC.ProductID = SI.ProductID
		WHERE SI.SaleID = @SaleID
		GROUP BY PC.ComponentID
	)
	MERGE Catalog.Component TRG
	USING CTE_SaleItem SRC ON SRC.ComponentID = TRG.ID
	WHEN MATCHED THEN
		UPDATE SET
			Quantity -= SRC.Quantity,
			Modified = Common.GetDateTime2()
	;

	RETURN 0
END
GO
PRINT N'Creating [Stock].[DeleteSaleItem]...';


GO
CREATE PROCEDURE [Stock].[DeleteSaleItem]
	@SaleID int,
	@Order smallint
AS
BEGIN
	SET NOCOUNT ON;

	DELETE
	FROM [Stock].[SaleItem]
	WHERE [SaleID] = @SaleID
		AND [Order] = @Order

	RETURN 0
END
GO
PRINT N'Creating [Stock].[GetNextSaleIDForApp]...';


GO
CREATE PROCEDURE [Stock].[GetNextSaleIDForApp]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @NextSaleID int

	SET @NextSaleID = Stock.GetNextSaleID()

	SELECT @NextSaleID AS NextSaleID

	RETURN 0
END
GO
PRINT N'Creating [Stock].[InsertSale]...';


GO
CREATE PROCEDURE [Stock].[InsertSale]
	@Sold date,
	@CustomerName nvarchar(50),
	@IsApproved bit
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @ID int

	SET @ID = Stock.GetNextSaleID()

	INSERT INTO [Stock].[Sale] (
		[ID],
		[Sold],
		[CustomerName],
		[IsApproved],
		[Created]
	)
	VALUES (
		@ID,
		@Sold,
		@CustomerName,
		@IsApproved,
		Common.GetDateTime2()
	)

	SELECT
		[ID],
		[Created]
	FROM [Stock].[Sale]
	WHERE [ID] = @ID

	RETURN 0
END
GO
PRINT N'Creating [Stock].[InsertSaleItem]...';


GO
CREATE PROCEDURE [Stock].[InsertSaleItem]
	@SaleID int,
	@ProductID int,
	@Quantity int
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Order smallint

	SELECT @Order =  ISNULL(MAX([Order]), 0) + 1
	FROM Stock.SaleItem
	WHERE SaleID = @SaleID

	INSERT INTO [Stock].[SaleItem] (
		[SaleID],
		[Order],
		[ProductID],
		[Quantity],
		[Created]
	)
	VALUES (
		@SaleID,
		@Order,
		@ProductID,
		@Quantity,
		Common.GetDateTime2()
	)

	SELECT
		[Order],
		[Created]
	FROM [Stock].[SaleItem]
	WHERE [SaleID] = @SaleID
		AND [Order] = @Order

	RETURN 0
END
GO
PRINT N'Creating [Stock].[UpdateSale]...';


GO
CREATE PROCEDURE [Stock].[UpdateSale]
	@ID int,
	@Sold date,
	@CustomerName nvarchar(50),
	@IsApproved bit
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [Stock].[Sale] SET
		[Sold] = @Sold,
		[CustomerName] = @CustomerName,
		[IsApproved] = @IsApproved,
		[Modified] = Common.GetDateTime2()
	WHERE [ID] = @ID

	SELECT [Modified]
	FROM [Stock].[Sale]
	WHERE [ID] = @ID

	RETURN 0
END
GO
PRINT N'Creating [Stock].[UpdateSaleItem]...';


GO
CREATE PROCEDURE [Stock].[UpdateSaleItem]
	@SaleID int,
	@Order smallint,
	@ProductID int,
	@Quantity int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [Stock].[SaleItem] SET
		[ProductID] = @ProductID,
		[Quantity] = @Quantity,
		[Modified] = Common.GetDateTime2()
	WHERE [SaleID] = @SaleID
		AND [Order] = @Order

	SELECT [Modified]
	FROM [Stock].[SaleItem]
	WHERE [SaleID] = @SaleID
		AND [Order] = @Order

	RETURN 0
END
GO
PRINT N'Creating [Stock].[Sale].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Prodeje', @level0type = N'SCHEMA', @level0name = N'Stock', @level1type = N'TABLE', @level1name = N'Sale';


GO
PRINT N'Creating [Stock].[Sale].[ID].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'PK - číslo prodeje', @level0type = N'SCHEMA', @level0name = N'Stock', @level1type = N'TABLE', @level1name = N'Sale', @level2type = N'COLUMN', @level2name = N'ID';


GO
PRINT N'Creating [Stock].[Sale].[Sold].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum prodeje', @level0type = N'SCHEMA', @level0name = N'Stock', @level1type = N'TABLE', @level1name = N'Sale', @level2type = N'COLUMN', @level2name = N'Sold';


GO
PRINT N'Creating [Stock].[Sale].[CustomerName].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Název zákazníka', @level0type = N'SCHEMA', @level0name = N'Stock', @level1type = N'TABLE', @level1name = N'Sale', @level2type = N'COLUMN', @level2name = N'CustomerName';


GO
PRINT N'Creating [Stock].[Sale].[IsApproved].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Je schválen', @level0type = N'SCHEMA', @level0name = N'Stock', @level1type = N'TABLE', @level1name = N'Sale', @level2type = N'COLUMN', @level2name = N'IsApproved';


GO
PRINT N'Creating [Stock].[Sale].[Created].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum a čas vytvoření záznamu', @level0type = N'SCHEMA', @level0name = N'Stock', @level1type = N'TABLE', @level1name = N'Sale', @level2type = N'COLUMN', @level2name = N'Created';


GO
PRINT N'Creating [Stock].[Sale].[Modified].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum a čas poslední změny záznamu', @level0type = N'SCHEMA', @level0name = N'Stock', @level1type = N'TABLE', @level1name = N'Sale', @level2type = N'COLUMN', @level2name = N'Modified';


GO
PRINT N'Creating [Stock].[SaleItem].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Položky prodejů', @level0type = N'SCHEMA', @level0name = N'Stock', @level1type = N'TABLE', @level1name = N'SaleItem';


GO
PRINT N'Creating [Stock].[SaleItem].[SaleID].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'FK Sale - prodej', @level0type = N'SCHEMA', @level0name = N'Stock', @level1type = N'TABLE', @level1name = N'SaleItem', @level2type = N'COLUMN', @level2name = N'SaleID';


GO
PRINT N'Creating [Stock].[SaleItem].[Order].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'PK - pořadí položky', @level0type = N'SCHEMA', @level0name = N'Stock', @level1type = N'TABLE', @level1name = N'SaleItem', @level2type = N'COLUMN', @level2name = N'Order';


GO
PRINT N'Creating [Stock].[SaleItem].[ProductID].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'FK Product - produkt', @level0type = N'SCHEMA', @level0name = N'Stock', @level1type = N'TABLE', @level1name = N'SaleItem', @level2type = N'COLUMN', @level2name = N'ProductID';


GO
PRINT N'Creating [Stock].[SaleItem].[Quantity].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Množství', @level0type = N'SCHEMA', @level0name = N'Stock', @level1type = N'TABLE', @level1name = N'SaleItem', @level2type = N'COLUMN', @level2name = N'Quantity';


GO
PRINT N'Creating [Stock].[SaleItem].[Created].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum a čas vytvoření záznamu', @level0type = N'SCHEMA', @level0name = N'Stock', @level1type = N'TABLE', @level1name = N'SaleItem', @level2type = N'COLUMN', @level2name = N'Created';


GO
PRINT N'Creating [Stock].[SaleItem].[Modified].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum a čas poslední změny záznamu', @level0type = N'SCHEMA', @level0name = N'Stock', @level1type = N'TABLE', @level1name = N'SaleItem', @level2type = N'COLUMN', @level2name = N'Modified';


GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [Stock].[SaleItem] WITH CHECK CHECK CONSTRAINT [FK_SaleItem_Product];

ALTER TABLE [Stock].[SaleItem] WITH CHECK CHECK CONSTRAINT [FK_SaleItem_Sale];


GO
PRINT N'Update complete.';


GO
