CREATE PROCEDURE [Stock].[GetNextSaleIDForApp]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @NextSaleID int

	SET @NextSaleID = Stock.GetNextSaleID()

	SELECT @NextSaleID AS NextSaleID

	RETURN 0
END