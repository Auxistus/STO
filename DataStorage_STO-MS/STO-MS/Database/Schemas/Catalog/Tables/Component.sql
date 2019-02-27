CREATE TABLE [Catalog].[Component]
(
	[ID] INT IDENTITY(1, 1) NOT NULL,
	[ComponentTypeID] TINYINT NOT NULL, 
	[Name] NVARCHAR(100) NOT NULL,
	[Quantity] INT NOT NULL,
	[Created] DATETIME2(2) NOT NULL,
	[Modified] DATETIME2(2) NULL,
	CONSTRAINT [PK_Component] PRIMARY KEY CLUSTERED ([ID] ASC), 
	CONSTRAINT [FK_Component_ComponentType] FOREIGN KEY ([ComponentTypeID]) REFERENCES [Catalog].[ComponentType]([ID])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Seznam komponent',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Component',
	@level2type = NULL,
	@level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'PK',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Component',
	@level2type = N'COLUMN',
	@level2name = N'ID'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'FK ComponentType - typ komponenty',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Component',
	@level2type = N'COLUMN',
	@level2name = N'ComponentTypeID'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Název',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Component',
	@level2type = N'COLUMN',
	@level2name = N'Name'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Množství',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Component',
	@level2type = N'COLUMN',
	@level2name = N'Quantity'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas vytvoření záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Component',
	@level2type = N'COLUMN',
	@level2name = N'Created'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas poslední změny záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'Component',
	@level2type = N'COLUMN',
	@level2name = N'Modified'