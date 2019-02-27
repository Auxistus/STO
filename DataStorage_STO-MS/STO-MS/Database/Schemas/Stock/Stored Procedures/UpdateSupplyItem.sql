CREATE PROCEDURE [Stock].[UpdateSupplyItem]
	@SupplyID int,
	@Order smallint,
	@ComponentID int,
	@Quantity int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [Stock].[SupplyItem] SET
		[ComponentID] = @ComponentID,
		[Quantity] = @Quantity,
		[Modified] = Common.GetDateTime2()
	WHERE [SupplyID] = @SupplyID
		AND [Order] = @Order

	SELECT [Modified]
	FROM [Stock].[SupplyItem]
	WHERE [SupplyID] = @SupplyID
		AND [Order] = @Order

	RETURN 0
END