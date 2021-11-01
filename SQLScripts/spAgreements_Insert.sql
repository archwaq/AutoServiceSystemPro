-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/28/2021>
-- Description:	<Insert information for a particular agreement>
-- =============================================
CREATE PROCEDURE dbo.spAgreements_Insert
	@ClientID int,
	@VehicleID int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

    insert into dbo.Agreements(ClientID, VehicleID)
	values (@ClientID, @VehicleID);

	select @id = SCOPE_IDENTITY();
END
GO
