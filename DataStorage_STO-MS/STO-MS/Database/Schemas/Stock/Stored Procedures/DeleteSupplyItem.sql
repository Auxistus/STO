CREATE PROCEDURE [Stock].[DeleteSupplyItem]
	@SupplyID int,
	@Order smallint
AS
BEGIN
	SET NOCOUNT ON;

	DELETE
	FROM [Stock].[SupplyItem]
	WHERE [SupplyID] = @SupplyID
		AND [Order] = @Order

	RETURN 0
END