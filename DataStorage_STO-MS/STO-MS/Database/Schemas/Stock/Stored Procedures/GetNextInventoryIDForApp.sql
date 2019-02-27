CREATE PROCEDURE [Stock].[GetNextInventoryIDForApp]
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @NextInventoryID int

	SET @NextInventoryID = Stock.GetNextInventoryID()

	SELECT @NextInventoryID AS NextInventoryID

	RETURN 0
END