CREATE PROCEDURE [Stock].[InsertInventory]
	@Entered date,
	@IsApproved bit
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @ID int

	SET @ID = Stock.GetNextInventoryID()

	INSERT INTO [Stock].[Inventory] (
		[ID],
		[Entered],
		[IsApproved],
		[Created]
	)
	VALUES (
		@ID,
		@Entered,
		@IsApproved,
		Common.GetDateTime2()
	)

	SELECT
		[ID],
		[Created]
	FROM [Stock].[Inventory]
	WHERE [ID] = @ID

	RETURN 0
END