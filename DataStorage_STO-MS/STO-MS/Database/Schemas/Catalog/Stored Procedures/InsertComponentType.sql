CREATE PROCEDURE [Catalog].[InsertComponentType]
	@Name nvarchar(50),
	@IsVisible bit
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [Catalog].[ComponentType] (
		[Name],
		[IsVisible],
		[Created]
	)
	VALUES (
		@Name,
		@IsVisible,
		Common.GetDateTime2()
	)

	SELECT
		[ID],
		[Created]
	FROM [Catalog].[ComponentType]
	WHERE [ID] = SCOPE_IDENTITY()

	RETURN 0
END