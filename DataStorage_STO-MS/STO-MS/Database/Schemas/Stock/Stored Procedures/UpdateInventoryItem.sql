CREATE PROCEDURE [Stock].[UpdateInventoryItem]
	@InventoryID int,
	@Order smallint,
	@ComponentID int,
	@StockQuantity int,
	@ActualkQuantity int,
	@TotalDifference int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [Stock].[InventoryItem] SET
		[ComponentID] = @ComponentID,
		[StockQuantity] = @StockQuantity,
		[ActualQuantity] = @ActualkQuantity,
		[TotalDifference] = @TotalDifference,
		[Modified] = Common.GetDateTime2()
	WHERE [InventoryID] = @InventoryID
		AND [Order] = @Order

	SELECT [Modified]
	FROM [Stock].[InventoryItem]
	WHERE [InventoryID] = @InventoryID
		AND [Order] = @Order

	RETURN 0
END