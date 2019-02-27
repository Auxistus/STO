CREATE PROCEDURE [Stock].[InsertSupply]
	@Delivered date,
	@SupplierName nvarchar(50),
	@Description nvarchar(MAX),
	@IsApproved bit
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @ID int

	SET @ID = Stock.GetNextSupplyID()

	INSERT INTO [Stock].[Supply] (
		[ID],
		[Delivered],
		[SupplierName],
		[Description],
		[IsApproved],
		[Created]
	)
	VALUES (
		@ID,
		@Delivered,
		@SupplierName,
		@Description,
		@IsApproved,
		Common.GetDateTime2()
	)

	SELECT
		[ID],
		[Created]
	FROM [Stock].[Supply]
	WHERE [ID] = @ID

	RETURN 0
END