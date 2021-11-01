-- ================================================
-- Template generated from Template Explorer using:
-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/29/2021>
-- Description:	<Insert information for a particular service repair>
-- =============================================
CREATE PROCEDURE dbo.spServiceRepairs_Insert
	@ServiceID int,
	@RepairID int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

    insert into dbo.ServiceRepairs( ServiceID, RepairID)
	values (@ServiceID, @RepairID);

	select @id = SCOPE_IDENTITY();
END
GO
