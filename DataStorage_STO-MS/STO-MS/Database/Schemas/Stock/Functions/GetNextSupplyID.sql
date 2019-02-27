﻿CREATE FUNCTION [Stock].[GetNextSupplyID]
(
)
RETURNS int
AS
BEGIN
	RETURN (
		SELECT ISNULL(MAX(ID), 0) + 1
		FROM Stock.Supply
	)
END