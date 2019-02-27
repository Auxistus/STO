CREATE TABLE [History].[Catalog_Component]
(
	[HistoryID] BIGINT IDENTITY(1, 1) NOT NULL, 
	[ID] INT  NOT NULL,
	[ComponentTypeID] TINYINT NOT NULL, 
	[Name] NVARCHAR(100) NOT NULL,
	[Quantity] INT NOT NULL,
	[Created] DATETIME2(2) NOT NULL,
	[Modified] DATETIME2(2) NULL, 
	[HistoryAction] CHAR(1) NOT NULL, 
	[HistoryCreated] DATETIME2(2) CONSTRAINT [DF_Catalog_Component_HistoryCreated] DEFAULT ([Common].[GetDateTime2]()) NOT NULL, 
	[HistoryCreatedBy] NVARCHAR(256) CONSTRAINT [DF_Catalog_Component_HistoryCreatedBy] DEFAULT (suser_sname()) NOT NULL, 
	CONSTRAINT [PK_Catalog_Component] PRIMARY KEY CLUSTERED ([HistoryID])
)
