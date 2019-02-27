CREATE TABLE [Stock].[InventoryItem]
(
	[InventoryID] INT NOT NULL, 
	[Order] SMALLINT NOT NULL, 
	[ComponentID] INT NOT NULL, 
	[StockQuantity] INT NOT NULL, 
	[ActualQuantity] INT NOT NULL, 
	[TotalDifference] INT NOT NULL, 
	[Created] DATETIME2(2) NOT NULL, 
	[Modified] DATETIME2(2) NULL, 
	CONSTRAINT [PK_InventoryItem] PRIMARY KEY CLUSTERED ([InventoryID], [Order]), 
	CONSTRAINT [FK_InventoryItem_Component] FOREIGN KEY ([ComponentID]) REFERENCES [Catalog].[Component]([ID]), 
	CONSTRAINT [FK_InventoryItem_Inventory] FOREIGN KEY ([InventoryID]) REFERENCES [Stock].[Inventory]([ID])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Položky inventur',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'InventoryItem',
	@level2type = NULL,
	@level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'FK Inventory - inventura',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'InventoryItem',
	@level2type = N'COLUMN',
	@level2name = N'InventoryID'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'PK - pořadí položky',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'InventoryItem',
	@level2type = N'COLUMN',
	@level2name = N'Order'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'FK Component - komponenta',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'InventoryItem',
	@level2type = N'COLUMN',
	@level2name = N'ComponentID'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Skladové množství',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'InventoryItem',
	@level2type = N'COLUMN',
	@level2name = N'StockQuantity'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Skutečné množství',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'InventoryItem',
	@level2type = N'COLUMN',
	@level2name = N'ActualQuantity'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Celkový rozdíl',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'InventoryItem',
	@level2type = N'COLUMN',
	@level2name = N'TotalDifference'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas vytvoření záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'InventoryItem',
	@level2type = N'COLUMN',
	@level2name = N'Created'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas poslední změny záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'InventoryItem',
	@level2type = N'COLUMN',
	@level2name = N'Modified'