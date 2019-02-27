CREATE PROCEDURE [Stock].[InsertSale]
	@Sold date,
	@CustomerName nvarchar(50),
	@IsApproved bit
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @ID int

	SET @ID = Stock.GetNextSaleID()

	INSERT INTO [Stock].[Sale] (
		[ID],
		[Sold],
		[CustomerName],
		[IsApproved],
		[Created]
	)
	VALUES (
		@ID,
		@Sold,
		@CustomerName,
		@IsApproved,
		Common.GetDateTime2()
	)

	SELECT
		[ID],
		[Created]
	FROM [Stock].[Sale]
	WHERE [ID] = @ID

	RETURN 0
END