-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/29/2021>
-- Description:	<Insert information for a particular service>
-- =============================================
CREATE PROCEDURE dbo.spService_Insert 
	@Description nvarchar(50),
	@id int = 0 output

AS
BEGIN
	SET NOCOUNT ON;

    insert into dbo.Service (Description, Active)
	values (@Description, 1);

	select @id = SCOPE_IDENTITY();
END
GO
