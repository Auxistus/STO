CREATE PROCEDURE [Catalog].[DeleteProduct_Component]
	@ProductID int,
	@ComponentID int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE
	FROM [Catalog].[Product_Component]
	WHERE [ProductID] = @ProductID
		AND [ComponentID] = @ComponentID

	RETURN 0
END