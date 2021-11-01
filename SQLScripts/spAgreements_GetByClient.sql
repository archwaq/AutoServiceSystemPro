-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/29/2021>
-- Description:	<Get detailed information for agreement in the system>
-- =============================================
CREATE PROCEDURE dbo.spAgreements_GetByClient 
	@ClientID int
AS
BEGIN
	SET NOCOUNT ON;

	select c.*
	from dbo.Agreements a
	inner join dbo.Vehicle c on a.VehicleID = c.id
	where a.ClientID = @ClientID;

END
GO
