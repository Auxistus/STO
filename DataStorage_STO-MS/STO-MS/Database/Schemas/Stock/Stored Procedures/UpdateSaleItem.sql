CREATE PROCEDURE [Stock].[UpdateSaleItem]
	@SaleID int,
	@Order smallint,
	@ProductID int,
	@Quantity int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [Stock].[SaleItem] SET
		[ProductID] = @ProductID,
		[Quantity] = @Quantity,
		[Modified] = Common.GetDateTime2()
	WHERE [SaleID] = @SaleID
		AND [Order] = @Order

	SELECT [Modified]
	FROM [Stock].[SaleItem]
	WHERE [SaleID] = @SaleID
		AND [Order] = @Order

	RETURN 0
END