CREATE PROCEDURE [Catalog].[InsertProduct_Component]
	@ProductID int,
	@ComponentID int,
	@Quantity smallint
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [Catalog].[Product_Component] (
		[ProductID],
		[ComponentID],
		[Quantity],
		[Created]
	)
	VALUES (
		@ProductID,
		@ComponentID,
		@Quantity,
		Common.GetDateTime2()
	)

	SELECT [Created]
	FROM [Catalog].[Product_Component]
	WHERE [ProductID] = @ProductID
		AND [ComponentID] = @ComponentID

	RETURN 0
END