
-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/27/2021>
-- Description:	<Insert information for a particular repair>
-- =============================================
CREATE PROCEDURE dbo.spRepair_Insert
	@CreatedDate date,
	@Description nvarchar(150),
	@Price money,
	@id int = 0 output
AS
BEGIN	
	SET NOCOUNT ON;

	insert into dbo.Repair (CreatedDate, Description, Price)
	values (@CreatedDate, @Description, @Price);

	select @id = SCOPE_IDENTITY();

END
GO
