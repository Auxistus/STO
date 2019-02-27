CREATE TABLE [Catalog].[Product]
(
	[ID] INT NOT NULL, 
	[Name] NVARCHAR(50) NOT NULL, 
	[Scale] SMALLINT NOT NULL, 
	[Created] DATETIME2(2) NOT NULL, 
	[Modified] DATETIME2(2) NULL, 
	CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([ID])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Seznam produktů',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Product',
	@level2type = NULL,
	@level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'PK - číslo produktu',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Product',
	@level2type = N'COLUMN',
	@level2name = N'ID'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Název',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Product',
	@level2type = N'COLUMN',
	@level2name = N'Name'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Měřítko',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Product',
	@level2type = N'COLUMN',
	@level2name = N'Scale'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas vytvoření záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Product',
	@level2type = N'COLUMN',
	@level2name = N'Created'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas poslední změny záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Product',
	@level2type = N'COLUMN',
	@level2name = N'Modified'