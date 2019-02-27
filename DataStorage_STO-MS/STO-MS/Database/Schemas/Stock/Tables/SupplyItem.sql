CREATE TABLE [Stock].[SupplyItem]
(
	[SupplyID] INT NOT NULL, 
	[Order] SMALLINT NOT NULL, 
	[ComponentID] INT NOT NULL, 
	[Quantity] INT NOT NULL, 
	[Created] DATETIME2(2) NOT NULL, 
	[Modified] DATETIME2(2) NULL, 
	CONSTRAINT [PK_SupplyItem] PRIMARY KEY CLUSTERED ([SupplyID], [Order]), 
	CONSTRAINT [FK_SupplyItem_Component] FOREIGN KEY ([ComponentID]) REFERENCES [Catalog].[Component]([ID]), 
	CONSTRAINT [FK_SupplyItem_Supply] FOREIGN KEY ([SupplyID]) REFERENCES [Stock].[Supply]([ID])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Položky dodávek',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'SupplyItem',
	@level2type = NULL,
	@level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'FK Supply - dodávka',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'SupplyItem',
	@level2type = N'COLUMN',
	@level2name = N'SupplyID'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'PK - pořadí položky',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'SupplyItem',
	@level2type = N'COLUMN',
	@level2name = N'Order'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'FK Component - komponenta',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'SupplyItem',
	@level2type = N'COLUMN',
	@level2name = N'ComponentID'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Množství',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'SupplyItem',
	@level2type = N'COLUMN',
	@level2name = N'Quantity'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas vytvoření záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'SupplyItem',
	@level2type = N'COLUMN',
	@level2name = N'Created'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas poslední změny záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'SupplyItem',
	@level2type = N'COLUMN',
	@level2name = N'Modified'