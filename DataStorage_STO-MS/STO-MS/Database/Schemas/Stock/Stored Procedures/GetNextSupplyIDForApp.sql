CREATE PROCEDURE [Stock].[GetNextSupplyIDForApp]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @NextSupplyID int

	SET @NextSupplyID = Stock.GetNextSupplyID()

	SELECT @NextSupplyID AS NextSupplyID

	RETURN 0
END