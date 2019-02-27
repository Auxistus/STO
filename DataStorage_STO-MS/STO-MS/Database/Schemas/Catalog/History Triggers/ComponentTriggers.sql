CREATE TRIGGER [Catalog].[TR_Component_HistoryLog]
	ON [Catalog].[Component]
	AFTER INSERT, DELETE
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [History].[Catalog_Component](
		[ID], 
		[ComponentTypeID],
		[Name],
		[Quantity],
		[Created],
		[Modified],
		[HistoryAction]
	)
	SELECT
		[ID], 
		[ComponentTypeID],
		[Name],
		[Quantity],
		[Created],
		[Modified],
		'D'
	FROM deleted
	UNION ALL
	SELECT
		[ID], 
		[ComponentTypeID],
		[Name],
		[Quantity],
		[Created],
		[Modified],
		'I'
	FROM inserted

END
GO
CREATE TRIGGER [Catalog].[TR_Component_HistoryLogU]
	ON [Catalog].[Component]
	AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [History].[Catalog_Component](
		[ID], 
		[ComponentTypeID],
		[Name],
		[Quantity],
		[Created],
		[Modified],
		[HistoryAction]
	)
	SELECT
		[ID], 
		[ComponentTypeID],
		[Name],
		[Quantity],
		[Created],
		[Modified],
		'U'
	FROM inserted
END
GO