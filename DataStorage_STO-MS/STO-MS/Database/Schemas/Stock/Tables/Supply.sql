CREATE TABLE [Stock].[Supply]
(
	[ID] INT NOT NULL, 
	[Delivered] DATE NOT NULL, 
	[SupplierName] NVARCHAR(50) NOT NULL, 
	[Description] NVARCHAR(MAX) NULL, 
	[IsApproved] BIT NOT NULL, 
	[Created] DATETIME2(2) NOT NULL, 
	[Modified] DATETIME2(2) NULL, 
	CONSTRAINT [PK_Supply] PRIMARY KEY CLUSTERED ([ID])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Dodávky',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Supply',
	@level2type = NULL,
	@level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'PK - číslo dodávky',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Supply',
	@level2type = N'COLUMN',
	@level2name = N'ID'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum dodání',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Supply',
	@level2type = N'COLUMN',
	@level2name = N'Delivered'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Název dodavatele',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Supply',
	@level2type = N'COLUMN',
	@level2name = N'SupplierName'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Popis',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Supply',
	@level2type = N'COLUMN',
	@level2name = N'Description'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Je schválen',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Supply',
	@level2type = N'COLUMN',
	@level2name = N'IsApproved'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas vytvoření záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Supply',
	@level2type = N'COLUMN',
	@level2name = N'Created'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
	@value = N'Datum a čas poslední změny záznamu',
	@level0type = N'SCHEMA',
	@level0name = N'Stock',
	@level1type = N'TABLE',
	@level1name = N'Supply',
	@level2type = N'COLUMN',
	@level2name = N'Modified'