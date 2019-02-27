CREATE PROCEDURE [Stock].[UpdateSupply]
	@ID int,
	@Delivered date,
	@SupplierName nvarchar(50),
	@Description nvarchar(MAX),
	@IsApproved bit
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [Stock].[Supply] SET
		[Delivered] = @Delivered,
		[SupplierName] = @SupplierName,
		[Description] = @Description,
		[IsApproved] = @IsApproved,
		[Modified] = Common.GetDateTime2()
	WHERE [ID] = @ID

	SELECT [Modified]
	FROM [Stock].[Supply]
	WHERE [ID] = @ID

	RETURN 0
END