USE [master]
GO
/****** Object:  Database [AutoServiceSystemPro]    Script Date: 2/18/2022 5:44:07 PM ******/
CREATE DATABASE [AutoServiceSystemPro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AutoServiceSystemPro', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AutoServiceSystemPro.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AutoServiceSystemPro_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AutoServiceSystemPro_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AutoServiceSystemPro] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AutoServiceSystemPro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AutoServiceSystemPro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET ARITHABORT OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AutoServiceSystemPro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AutoServiceSystemPro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AutoServiceSystemPro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AutoServiceSystemPro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET RECOVERY FULL 
GO
ALTER DATABASE [AutoServiceSystemPro] SET  MULTI_USER 
GO
ALTER DATABASE [AutoServiceSystemPro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AutoServiceSystemPro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AutoServiceSystemPro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AutoServiceSystemPro] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AutoServiceSystemPro] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AutoServiceSystemPro] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AutoServiceSystemPro', N'ON'
GO
ALTER DATABASE [AutoServiceSystemPro] SET QUERY_STORE = OFF
GO
USE [AutoServiceSystemPro]
GO
/****** Object:  Table [dbo].[Agreements]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agreements](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[VehicleID] [int] NOT NULL,
 CONSTRAINT [PK_Agreements] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[CellphoneNumber] [nvarchar](20) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[NationalCardNumber] [nvarchar](20) NOT NULL,
	[PersonalIdentificationNumber] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Repair]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repair](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedDate] [date] NOT NULL,
	[Description] [nvarchar](150) NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_Repair] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceEntries]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceEntries](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ServiceID] [int] NOT NULL,
	[ClientID] [int] NOT NULL,
 CONSTRAINT [PK_ServiceEntries] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceRepairs]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceRepairs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ServiceID] [int] NOT NULL,
	[RepairID] [int] NOT NULL,
 CONSTRAINT [PK_ServiceRepairs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[VehicleIdentificationNumber] [nvarchar](17) NOT NULL,
	[Plate] [nvarchar](10) NOT NULL,
	[Make] [nvarchar](20) NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[Color] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Agreements]  WITH CHECK ADD  CONSTRAINT [FK_Agreements_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([id])
GO
ALTER TABLE [dbo].[Agreements] CHECK CONSTRAINT [FK_Agreements_Client]
GO
ALTER TABLE [dbo].[Agreements]  WITH CHECK ADD  CONSTRAINT [FK_Agreements_Vehicle] FOREIGN KEY([VehicleID])
REFERENCES [dbo].[Vehicle] ([id])
GO
ALTER TABLE [dbo].[Agreements] CHECK CONSTRAINT [FK_Agreements_Vehicle]
GO
ALTER TABLE [dbo].[ServiceEntries]  WITH CHECK ADD  CONSTRAINT [FK_ServiceEntries_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([id])
GO
ALTER TABLE [dbo].[ServiceEntries] CHECK CONSTRAINT [FK_ServiceEntries_Client]
GO
ALTER TABLE [dbo].[ServiceEntries]  WITH CHECK ADD  CONSTRAINT [FK_ServiceEntries_Service] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Service] ([id])
GO
ALTER TABLE [dbo].[ServiceEntries] CHECK CONSTRAINT [FK_ServiceEntries_Service]
GO
ALTER TABLE [dbo].[ServiceRepairs]  WITH CHECK ADD  CONSTRAINT [FK_ServiceRepairs_Repair] FOREIGN KEY([RepairID])
REFERENCES [dbo].[Repair] ([id])
GO
ALTER TABLE [dbo].[ServiceRepairs] CHECK CONSTRAINT [FK_ServiceRepairs_Repair]
GO
ALTER TABLE [dbo].[ServiceRepairs]  WITH CHECK ADD  CONSTRAINT [FK_ServiceRepairs_Service] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Service] ([id])
GO
ALTER TABLE [dbo].[ServiceRepairs] CHECK CONSTRAINT [FK_ServiceRepairs_Service]
GO
/****** Object:  StoredProcedure [dbo].[spAgreements_GetByClient]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/29/2021>
-- Description:	<Get detailed information for agreement in the system>
-- =============================================
CREATE PROCEDURE [dbo].[spAgreements_GetByClient] 
	@ClientID int
AS
BEGIN
	SET NOCOUNT ON;

	select c.*
	from dbo.Agreements a
	inner join dbo.Vehicle c on a.VehicleID = c.id
	where a.ClientID = @ClientID;

END
GO
/****** Object:  StoredProcedure [dbo].[spAgreements_Insert]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/28/2021>
-- Description:	<Insert information for a particular agreement>
-- =============================================
CREATE PROCEDURE [dbo].[spAgreements_Insert]
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
/****** Object:  StoredProcedure [dbo].[spClient_GetAll]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/28/2021>
-- Description:	<Get detailed information for clients in the system>
-- =============================================
CREATE PROCEDURE [dbo].[spClient_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

    select *
	from dbo.Client;

END
GO
/****** Object:  StoredProcedure [dbo].[spClient_GetByService]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/30/2021>
-- Description:	<Get detailed information for client in service entry kept in the system>
-- =============================================
CREATE PROCEDURE [dbo].[spClient_GetByService]
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
/****** Object:  StoredProcedure [dbo].[spClient_Insert]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/28/2021>
-- Description:	<Insert information for a particular client>
-- =============================================
CREATE PROCEDURE [dbo].[spClient_Insert] 
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
/****** Object:  StoredProcedure [dbo].[spRepair_Insert]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/27/2021>
-- Description:	<Insert information for a particular repair>
-- =============================================
CREATE PROCEDURE [dbo].[spRepair_Insert]
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
/****** Object:  StoredProcedure [dbo].[spRepairs_GetByService]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/30/2021>
-- Description:	<Get detailed information for repair service in the system>
-- =============================================
CREATE PROCEDURE [dbo].[spRepairs_GetByService]
	@ServiceID int
AS
BEGIN
	SET NOCOUNT ON;

    select r.*
	from dbo.Repair r
	inner join dbo.ServiceRepairs s on r.id = s.RepairID
	where s.ServiceID = @ServiceID;

END
GO
/****** Object:  StoredProcedure [dbo].[spService_Insert]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/29/2021>
-- Description:	<Insert information for a particular service>
-- =============================================
CREATE PROCEDURE [dbo].[spService_Insert] 
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
/****** Object:  StoredProcedure [dbo].[spServiceEntries_Insert]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/29/2021>
-- Description:	<Insert information for a particular service entry>
-- =============================================
CREATE PROCEDURE [dbo].[spServiceEntries_Insert] 
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
/****** Object:  StoredProcedure [dbo].[spServiceRepairs_Insert]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:
-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/29/2021>
-- Description:	<Insert information for a particular service repair>
-- =============================================
CREATE PROCEDURE [dbo].[spServiceRepairs_Insert]
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
/****** Object:  StoredProcedure [dbo].[spServices_GetAll]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/30/2021>
-- Description:	<Get detailed information for active services in the system>
-- =============================================
CREATE PROCEDURE [dbo].[spServices_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

    select *
	from dbo.Service
	where Active =1;

END
GO
/****** Object:  StoredProcedure [dbo].[spVehicle_GetAll]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/28/2021>
-- Description:	<Get detailed information for vehicles in the system>
-- =============================================
CREATE PROCEDURE [dbo].[spVehicle_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	select * from
	dbo.Vehicle

END
GO
/****** Object:  StoredProcedure [dbo].[spVehicle_Insert]    Script Date: 2/18/2022 5:44:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Evelin Kolev>
-- Create date: <10/27/2021>
-- Description:	<Insert information for a particular vehicle>
-- =============================================
CREATE PROCEDURE [dbo].[spVehicle_Insert]
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
USE [master]
GO
ALTER DATABASE [AutoServiceSystemPro] SET  READ_WRITE 
GO
