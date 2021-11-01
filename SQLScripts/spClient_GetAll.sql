-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/28/2021>
-- Description:	<Get detailed information for clients in the system>
-- =============================================
CREATE PROCEDURE dbo.spClient_GetAll
AS
BEGIN
	SET NOCOUNT ON;

    select *
	from dbo.Client;

END
GO
