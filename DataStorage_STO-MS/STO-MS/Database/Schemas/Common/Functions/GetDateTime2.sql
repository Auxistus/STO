CREATE FUNCTION [Common].[GetDateTime2]
(
)
RETURNS datetime2(2)
AS
BEGIN
	RETURN CAST(GETDATE() AS datetime2(2))
END
