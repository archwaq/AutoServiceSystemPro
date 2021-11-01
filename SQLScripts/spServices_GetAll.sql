-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/30/2021>
-- Description:	<Get detailed information for active services in the system>
-- =============================================
CREATE PROCEDURE dbo.spServices_GetAll
AS
BEGIN
	SET NOCOUNT ON;

    select *
	from dbo.Service
	where Active =1;

END
GO
