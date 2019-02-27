CREATE PROCEDURE [Stock].[CalculateComponentStockBySale]
	@SaleID int
AS
BEGIN
	SET NOCOUNT ON;

	WITH CTE_SaleItem AS (
		SELECT
			PC.ComponentID,
			SUM(SI.Quantity) AS Quantity
		FROM Stock.SaleItem SI
			INNER JOIN Catalog.Product_Component PC ON PC.ProductID = SI.ProductID
		WHERE SI.SaleID = @SaleID
		GROUP BY PC.ComponentID
	)
	MERGE Catalog.Component TRG
	USING CTE_SaleItem SRC ON SRC.ComponentID = TRG.ID
	WHEN MATCHED THEN
		UPDATE SET
			Quantity -= SRC.Quantity,
			Modified = Common.GetDateTime2()
	;

	RETURN 0
END