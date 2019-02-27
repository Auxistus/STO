CREATE PROCEDURE [Catalog].[UpdateProduct]
	@ID int,
	@Name nvarchar(50),
	@Scale smallint
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [Catalog].[Product] SET
		[Name] = @Name,
		[Scale] = @Scale,
		[Modified] = Common.GetDateTime2()
	WHERE [ID] = @ID

	SELECT [Modified]
	FROM [Catalog].[Product]
	WHERE [ID] = @ID

	RETURN 0
END