CREATE PROCEDURE [Stock].[CalculateComponentStockBySupply]
	@SupplyID int
AS
BEGIN
	SET NOCOUNT ON;

	WITH CTE_SupplyItem AS (
		SELECT
			ComponentID,
			SUM(Quantity) AS Quantity
		FROM Stock.SupplyItem
		WHERE SupplyID = @SupplyID
		GROUP BY ComponentID
	)
	MERGE Catalog.Component TRG
	USING CTE_SupplyItem SRC ON SRC.ComponentID = TRG.ID
	WHEN MATCHED THEN
		UPDATE SET
			Quantity += SRC.Quantity,
			Modified = Common.GetDateTime2()
	;

	RETURN 0
END