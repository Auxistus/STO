CREATE TABLE [Catalog].[ComponentType]
(
	[ID] TINYINT IDENTITY(1, 1) NOT NULL, 
	[Name] NVARCHAR(50) NOT NULL, 
	[IsVisible] BIT NOT NULL, 
	[Created] DATETIME2(2) NOT NULL, 
	[Modified] DATETIME2(2) NULL, 
	CONSTRAINT [PK_ComponentType] PRIMARY KEY ([ID])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Číselník typů komponent',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'ComponentType',
	@level2type = NULL,
	@level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'PK',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'ComponentType',
	@level2type = N'COLUMN',
	@level2name = N'ID'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Název',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'ComponentType',
	@level2type = N'COLUMN',
	@level2name = N'Name'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Je viditelný',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'ComponentType',
	@level2type = N'COLUMN',
	@level2name = N'IsVisible'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas vytvoření záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'ComponentType',
	@level2type = N'COLUMN',
	@level2name = N'Created'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas poslední změny záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Catalog',
	@level1type = N'TABLE',
	@level1name = N'ComponentType',
	@level2type = N'COLUMN',
	@level2name = N'Modified'