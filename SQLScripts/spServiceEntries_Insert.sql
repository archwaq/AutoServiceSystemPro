-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/29/2021>
-- Description:	<Insert information for a particular service entry>
-- =============================================
CREATE PROCEDURE dbo.spServiceEntries_Insert 
	@ServiceID int,
	@ClientID int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

    insert into dbo.ServiceEntries(ServiceID, ClientID)
	values(@ServiceID, @ClientID);

	select @id = SCOPE_IDENTITY();

END
GO
