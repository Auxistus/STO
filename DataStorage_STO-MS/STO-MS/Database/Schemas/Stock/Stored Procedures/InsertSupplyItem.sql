CREATE PROCEDURE [Stock].[InsertSupplyItem]
	@SupplyID int,
	@ComponentID int,
	@Quantity int
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Order smallint

	SELECT @Order =  ISNULL(MAX([Order]), 0) + 1
	FROM Stock.SupplyItem
	WHERE SupplyID = @SupplyID

	INSERT INTO [Stock].[SupplyItem] (
		[SupplyID],
		[Order],
		[ComponentID],
		[Quantity],
		[Created]
	)
	VALUES (
		@SupplyID,
		@Order,
		@ComponentID,
		@Quantity,
		Common.GetDateTime2()
	)

	SELECT
		[Order],
		[Created]
	FROM [Stock].[SupplyItem]
	WHERE [SupplyID] = @SupplyID
		AND [Order] = @Order

	RETURN 0
END