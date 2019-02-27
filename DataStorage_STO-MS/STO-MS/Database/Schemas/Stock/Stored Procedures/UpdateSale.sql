CREATE PROCEDURE [Stock].[UpdateSale]
	@ID int,
	@Sold date,
	@CustomerName nvarchar(50),
	@IsApproved bit
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [Stock].[Sale] SET
		[Sold] = @Sold,
		[CustomerName] = @CustomerName,
		[IsApproved] = @IsApproved,
		[Modified] = Common.GetDateTime2()
	WHERE [ID] = @ID

	SELECT [Modified]
	FROM [Stock].[Sale]
	WHERE [ID] = @ID

	RETURN 0
END