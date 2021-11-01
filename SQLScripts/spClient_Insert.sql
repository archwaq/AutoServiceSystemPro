-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/28/2021>
-- Description:	<Insert information for a particular client>
-- =============================================
CREATE PROCEDURE dbo.spClient_Insert 
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@CellphoneNumber nvarchar(20),
	@Address nvarchar(100),
	@Email nvarchar(255),
	@NationalCardNumber nvarchar(20),
	@PersonalIdentificationNumber nvarchar(10),
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Client (FirstName, LastName, CellphoneNumber, Address, Email, NationalCardNumber, PersonalIdentificationNumber)
	values (@FirstName, @LastName, @CellphoneNumber, @Address, @Email, @NationalCardNumber, @PersonalIdentificationNumber);

	select @id = SCOPE_IDENTITY();
END
GO
