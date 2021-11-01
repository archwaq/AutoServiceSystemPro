-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/30/2021>
-- Description:	<Get detailed information for repair service in the system>
-- =============================================
CREATE PROCEDURE dbo.spRepairs_GetByService
	@ServiceID int
AS
BEGIN
	SET NOCOUNT ON;

    select r.*
	from dbo.Repair r
	inner join dbo.ServiceRepairs s on r.id = s.RepairID
	where s.ServiceID = @ServiceID;

END
GO
