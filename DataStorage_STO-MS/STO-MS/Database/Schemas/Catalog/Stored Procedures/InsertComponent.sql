CREATE PROCEDURE [Catalog].[InsertComponent]
	@ComponentTypeID tinyint,
	@Name nvarchar(100),
	@Quantity int
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [Catalog].[Component] (
		[ComponentTypeID],
		[Name],
		[Quantity],
		[Created]
	)
	VALUES (
		@ComponentTypeID,
		@Name,
		@Quantity,
		Common.GetDateTime2()
	)

	SELECT
		[ID],
		[Created]
	FROM [Catalog].[Component]
	WHERE [ID] = SCOPE_IDENTITY()

	RETURN 0
END