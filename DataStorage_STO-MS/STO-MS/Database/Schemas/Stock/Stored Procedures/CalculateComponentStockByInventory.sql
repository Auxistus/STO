CREATE PROCEDURE [Stock].[CalculateComponentStockByInventory]
	@InventoryID int
AS
BEGIN
	SET NOCOUNT ON;

	WITH CTE_InventoryItem AS (
		SELECT
			ComponentID,
			SUM(ActualQuantity) AS ActualQuantity
		FROM Stock.InventoryItem
		WHERE InventoryID = @InventoryID
		GROUP BY ComponentID
	)
	MERGE Catalog.Component TRG
	USING CTE_InventoryItem SRC ON SRC.ComponentID = TRG.ID
	WHEN MATCHED THEN
		UPDATE SET
			Quantity = SRC.ActualQuantity,
			Modified = Common.GetDateTime2()
	;

	RETURN 0
END