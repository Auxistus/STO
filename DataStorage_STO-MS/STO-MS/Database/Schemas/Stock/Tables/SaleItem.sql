CREATE TABLE [Stock].[SaleItem]
(
	[SaleID] INT NOT NULL, 
	[Order] SMALLINT NOT NULL, 
	[ProductID] INT NOT NULL, 
	[Quantity] INT NOT NULL, 
	[Created] DATETIME2(2) NOT NULL, 
	[Modified] DATETIME2(2) NULL, 
	CONSTRAINT [PK_SaleItem] PRIMARY KEY CLUSTERED ([SaleID], [Order]), 
	CONSTRAINT [FK_SaleItem_Product] FOREIGN KEY ([ProductID]) REFERENCES [Catalog].[Product]([ID]), 
	CONSTRAINT [FK_SaleItem_Sale] FOREIGN KEY ([SaleID]) REFERENCES [Stock].[Sale]([ID])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Položky prodejů',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'SaleItem',
	@level2type = NULL,
	@level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'FK Sale - prodej',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'SaleItem',
	@level2type = N'COLUMN',
	@level2name = N'SaleID'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'PK - pořadí položky',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'SaleItem',
	@level2type = N'COLUMN',
	@level2name = N'Order'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'FK Product - produkt',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'SaleItem',
	@level2type = N'COLUMN',
	@level2name = N'ProductID'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Množství',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'SaleItem',
	@level2type = N'COLUMN',
	@level2name = N'Quantity'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas vytvoření záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'SaleItem',
	@level2type = N'COLUMN',
	@level2name = N'Created'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas poslední změny záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'SaleItem',
	@level2type = N'COLUMN',
	@level2name = N'Modified'