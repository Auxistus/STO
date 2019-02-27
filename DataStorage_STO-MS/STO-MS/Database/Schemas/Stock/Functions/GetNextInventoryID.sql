CREATE FUNCTION [Stock].[GetNextInventoryID]
(
)
RETURNS int
AS
BEGIN
	RETURN (
		SELECT ISNULL(MAX(ID), 0) + 1
		FROM Stock.Inventory
	)
END