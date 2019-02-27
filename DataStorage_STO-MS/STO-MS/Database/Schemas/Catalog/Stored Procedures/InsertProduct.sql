CREATE PROCEDURE [Catalog].[InsertProduct]
	@ID int,
	@Name nvarchar(50),
	@Scale smallint
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [Catalog].[Product] (
		[ID],
		[Name],
		[Scale],
		[Created]
	)
	VALUES (
		@ID,
		@Name,
		@Scale,
		Common.GetDateTime2()
	)

	SELECT [Created]
	FROM [Catalog].[Product]
	WHERE [ID] = @ID

	RETURN 0
END