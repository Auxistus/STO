CREATE TABLE [Stock].[Inventory]
(
	[ID] INT NOT NULL, 
	[Entered] DATE NOT NULL, 
	[IsApproved] BIT NOT NULL, 
	[Created] DATETIME2(2) NOT NULL, 
	[Modified] DATETIME2(2) NULL, 
	CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED ([ID])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Inventury',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Inventory',
	@level2type = NULL,
	@level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'PK - číslo inventury',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Inventory',
	@level2type = N'COLUMN',
	@level2name = N'ID'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum zadání',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Inventory',
	@level2type = N'COLUMN',
	@level2name = N'Entered'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Je schválen',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Inventory',
	@level2type = N'COLUMN',
	@level2name = N'IsApproved'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas vytvoření záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Inventory',
	@level2type = N'COLUMN',
	@level2name = N'Created'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas poslední změny záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Inventory',
	@level2type = N'COLUMN',
	@level2name = N'Modified'