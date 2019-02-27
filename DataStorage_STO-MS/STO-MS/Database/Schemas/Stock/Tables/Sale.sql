CREATE TABLE [Stock].[Sale]
(
	[ID] INT NOT NULL, 
	[Sold] DATE NOT NULL, 
	[CustomerName] NVARCHAR(50) NULL, 
	[IsApproved] BIT NOT NULL, 
	[Created] DATETIME2(2) NOT NULL, 
	[Modified] DATETIME2(2) NULL, 
	CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED ([ID]) 
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Prodeje',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Sale',
	@level2type = NULL,
	@level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'PK - číslo prodeje',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Sale',
	@level2type = N'COLUMN',
	@level2name = N'ID'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum prodeje',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Sale',
	@level2type = N'COLUMN',
	@level2name = N'Sold'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Název zákazníka',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Sale',
	@level2type = N'COLUMN',
	@level2name = N'CustomerName'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Je schválen',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Sale',
	@level2type = N'COLUMN',
	@level2name = N'IsApproved'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas vytvoření záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Sale',
	@level2type = N'COLUMN',
	@level2name = N'Created'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas poslední změny záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Sale',
	@level2type = N'COLUMN',
	@level2name = N'Modified'