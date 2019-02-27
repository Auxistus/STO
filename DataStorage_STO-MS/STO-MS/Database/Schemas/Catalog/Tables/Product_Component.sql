CREATE TABLE [Catalog].[Product_Component]
(
	[ProductID] INT NOT NULL, 
	[ComponentID] INT NOT NULL, 
	[Quantity] SMALLINT NOT NULL, 
	[Created] DATETIME2(2) NOT NULL, 
	CONSTRAINT [PK_Product_Component] PRIMARY KEY CLUSTERED ([ProductID], [ComponentID]), 
	CONSTRAINT [FK_Product_Component_Component] FOREIGN KEY ([ComponentID]) REFERENCES [Catalog].[Component]([ID]), 
	CONSTRAINT [FK_Product_Component_Product] FOREIGN KEY ([ProductID]) REFERENCES [Catalog].[Product]([ID])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Přiřazení komponent k produktům',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Product_Component',
	@level2type = NULL,
	@level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'FK Product - produkt',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Product_Component',
	@level2type = N'COLUMN',
	@level2name = N'ProductID'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'FK Component - komponenta',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Product_Component',
	@level2type = N'COLUMN',
	@level2name = N'ComponentID'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Množství',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Product_Component',
	@level2type = N'COLUMN',
	@level2name = N'Quantity'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas vytvoření záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Product_Component',
	@level2type = N'COLUMN',
	@level2name = N'Created'