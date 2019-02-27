CREATE PROCEDURE [Catalog].[UpdateComponent]
	@ID int,
	@ComponentTypeID tinyint,
	@Name nvarchar(100),
	@Quantity int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [Catalog].[Component] SET
		[ComponentTypeID] = @ComponentTypeID,
		[Name] = @Name,
		[Quantity] = @Quantity,
		[Modified] = Common.GetDateTime2()
	WHERE [ID] = @ID

	SELECT [Modified]
	FROM [Catalog].[Component]
	WHERE [ID] = @ID

	RETURN 0
END