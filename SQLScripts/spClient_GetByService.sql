-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/30/2021>
-- Description:	<Get detailed information for client in service entry kept in the system>
-- =============================================
CREATE PROCEDURE dbo.spClient_GetByService
	@ServiceID int
AS
BEGIN
	SET NOCOUNT ON;

    select c.*
	from dbo.Client c
	inner join dbo.ServiceEntries s on c.id = s.ClientID
	where s.ServiceID = @ServiceID;

END
GO
