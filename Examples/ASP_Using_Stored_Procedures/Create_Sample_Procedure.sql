CREATE PROCEDURE [dbo].[Sample_Procedure]
	@p_on_hand decimal(4) = 0,
	@p_storehouse char(1) = 1
AS
	SELECT *
	FROM ITEM
	WHERE ON_HAND > @p_on_hand AND
		STOREHOUSE = @p_storehouse
RETURN 0