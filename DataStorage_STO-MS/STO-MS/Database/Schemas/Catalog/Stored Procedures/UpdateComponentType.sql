CREATE PROCEDURE [Catalog].[UpdateComponentType]
	@ID tinyint,
	@Name nvarchar(50),
	@IsVisible bit
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [Catalog].[ComponentType] SET
		[Name] = @Name,
		[IsVisible] = @IsVisible,
		[Modified] = Common.GetDateTime2()
	WHERE [ID] = @ID

	SELECT [Modified]
	FROM [Catalog].[ComponentType]
	WHERE [ID] = @ID

	RETURN 0
END