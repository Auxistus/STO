CREATE PROCEDURE [Stock].[DeleteInventoryItem]
	@InventoryID int,
	@Order smallint
AS
BEGIN
	SET NOCOUNT ON;

	DELETE
	FROM [Stock].[InventoryItem]
	WHERE [InventoryID] = @InventoryID
		AND [Order] = @Order

	RETURN 0
END