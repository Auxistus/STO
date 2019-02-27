CREATE PROCEDURE [Stock].[InsertSaleItem]
	@SaleID int,
	@ProductID int,
	@Quantity int
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Order smallint

	SELECT @Order =  ISNULL(MAX([Order]), 0) + 1
	FROM Stock.SaleItem
	WHERE SaleID = @SaleID

	INSERT INTO [Stock].[SaleItem] (
		[SaleID],
		[Order],
		[ProductID],
		[Quantity],
		[Created]
	)
	VALUES (
		@SaleID,
		@Order,
		@ProductID,
		@Quantity,
		Common.GetDateTime2()
	)

	SELECT
		[Order],
		[Created]
	FROM [Stock].[SaleItem]
	WHERE [SaleID] = @SaleID
		AND [Order] = @Order

	RETURN 0
END