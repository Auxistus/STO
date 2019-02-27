CREATE PROCEDURE [Stock].[DeleteSaleItem]
	@SaleID int,
	@Order smallint
AS
BEGIN
	SET NOCOUNT ON;

	DELETE
	FROM [Stock].[SaleItem]
	WHERE [SaleID] = @SaleID
		AND [Order] = @Order

	RETURN 0
END