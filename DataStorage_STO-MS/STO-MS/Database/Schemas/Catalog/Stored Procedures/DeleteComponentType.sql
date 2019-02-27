CREATE PROCEDURE [Catalog].[DeleteComponentType]
	@ID tinyint
AS
BEGIN
	SET NOCOUNT ON;

	DELETE
	FROM [Catalog].[ComponentType]
	WHERE [ID] = @ID

	RETURN 0
END