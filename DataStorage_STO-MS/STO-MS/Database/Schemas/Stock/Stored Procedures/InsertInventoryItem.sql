CREATE PROCEDURE [Stock].[InsertInventoryItem]
	@InventoryID int,
	@ComponentID int,
	@StockQuantity int,
	@ActualkQuantity int,
	@TotalDifference int
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Order smallint

	SELECT @Order =  ISNULL(MAX([Order]), 0) + 1
	FROM Stock.InventoryItem
	WHERE InventoryID = @InventoryID

	INSERT INTO [Stock].[InventoryItem] (
		[InventoryID],
		[Order],
		[ComponentID],
		[StockQuantity],
		[ActualQuantity],
		[TotalDifference],
		[Created]
	)
	VALUES (
		@InventoryID,
		@Order,
		@ComponentID,
		@StockQuantity,
		@ActualkQuantity,
		@TotalDifference,
		Common.GetDateTime2()
	)

	SELECT
		[Order],
		[Created]
	FROM [Stock].[InventoryItem]
	WHERE [InventoryID] = @InventoryID
		AND [Order] = @Order

	RETURN 0
END