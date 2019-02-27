CREATE PROCEDURE [Stock].[UpdateInventory]
	@ID int,
	@Entered date,
	@IsApproved bit
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [Stock].[Inventory] SET
		[Entered] = @Entered,
		[IsApproved] = @IsApproved,
		[Modified] = Common.GetDateTime2()
	WHERE [ID] = @ID

	SELECT [Modified]
	FROM [Stock].[Inventory]
	WHERE [ID] = @ID

	RETURN 0
END