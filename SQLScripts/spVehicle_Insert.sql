-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/27/2021>
-- Description:	<Insert information for a particular vehicle>
-- =============================================
CREATE PROCEDURE dbo.spVehicle_Insert
	@VehicleIdentificationNumber nvarchar(17),
	@Plate nvarchar(10),
	@Make nvarchar(20),
	@Model nvarchar(50),
	@Color nvarchar(20),
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;
	
	insert into dbo.Vehicle (VehicleIdentificationNumber, Plate, Make, Model, Color)
	values (@VehicleIdentificationNumber, @Plate, @Make, @Model, @Color);

	select @id=SCOPE_IDENTITY();
END
GO
