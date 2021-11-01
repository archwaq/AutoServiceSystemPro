-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/28/2021>
-- Description:	<Get detailed information for vehicles in the system>
-- =============================================
CREATE PROCEDURE dbo.spVehicle_GetAll
AS
BEGIN
	SET NOCOUNT ON;

	select * from
	dbo.Vehicle

END
GO
