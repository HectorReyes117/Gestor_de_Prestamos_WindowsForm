USE [master]
GO
/****** Object:  Database [PruebasFinal1]    Script Date: 17/06/2022 16:29:29 ******/
CREATE DATABASE [PruebasFinal1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PruebasFinal1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\PruebasFinal1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PruebasFinal1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\PruebasFinal1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [PruebasFinal1] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PruebasFinal1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PruebasFinal1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PruebasFinal1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PruebasFinal1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PruebasFinal1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PruebasFinal1] SET ARITHABORT OFF 
GO
ALTER DATABASE [PruebasFinal1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PruebasFinal1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PruebasFinal1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PruebasFinal1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PruebasFinal1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PruebasFinal1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PruebasFinal1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PruebasFinal1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PruebasFinal1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PruebasFinal1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PruebasFinal1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PruebasFinal1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PruebasFinal1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PruebasFinal1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PruebasFinal1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PruebasFinal1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PruebasFinal1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PruebasFinal1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PruebasFinal1] SET  MULTI_USER 
GO
ALTER DATABASE [PruebasFinal1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PruebasFinal1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PruebasFinal1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PruebasFinal1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PruebasFinal1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PruebasFinal1] SET QUERY_STORE = OFF
GO
USE [PruebasFinal1]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 17/06/2022 16:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID] [int] NOT NULL,
	[Cedula] [varchar](60) NOT NULL,
	[Nombre] [varchar](60) NOT NULL,
	[Correo_Electronico] [varchar](60) NOT NULL,
	[Direccion] [varchar](60) NULL,
	[Telefono] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cuotasApagar]    Script Date: 17/06/2022 16:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cuotasApagar](
	[id] [int] NULL,
	[cuotapagar] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movimientos_Prestamos]    Script Date: 17/06/2022 16:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movimientos_Prestamos](
	[Id] [int] NOT NULL,
	[Prestamo] [int] NOT NULL,
	[Monto_Pendiente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagos]    Script Date: 17/06/2022 16:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos](
	[Id] [int] NOT NULL,
	[Fecha] [varchar](60) NOT NULL,
	[Prestamo] [int] NOT NULL,
	[Cliente] [varchar](60) NOT NULL,
	[Monto_Pagado] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prestamos]    Script Date: 17/06/2022 16:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prestamos](
	[Id] [int] NOT NULL,
	[Fecha] [varchar](60) NOT NULL,
	[Monto_Prestamo] [int] NOT NULL,
	[Cliente] [varchar](60) NOT NULL,
	[Cuotas] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaCuota]    Script Date: 17/06/2022 16:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaCuota](
	[Id] [int] NOT NULL,
	[Cuotas] [int] NOT NULL,
UNIQUE NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[ClientesCedula]    Script Date: 17/06/2022 16:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ClientesCedula]
@Cedula varchar(60)
as
begin

select * from Clientes where Cedula = @Cedula
 
end
GO
/****** Object:  StoredProcedure [dbo].[ClientesCorreoElectronico]    Script Date: 17/06/2022 16:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ClientesCorreoElectronico]
@Correo varchar(60)
as
begin

select * from Clientes where Correo_Electronico = @Correo

end
GO
/****** Object:  StoredProcedure [dbo].[ClientesNombre]    Script Date: 17/06/2022 16:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ClientesNombre]
@Nombre varchar(60)
as
begin

select * from Clientes where Nombre = @Nombre

end
GO
/****** Object:  StoredProcedure [dbo].[MovimientosId]    Script Date: 17/06/2022 16:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[MovimientosId] 
@id int
as
begin

select * from Movimientos_Prestamos where Id=@id 
 
end
GO
/****** Object:  StoredProcedure [dbo].[PagosRangos]    Script Date: 17/06/2022 16:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PagosRangos]
@desde varchar(60),
@hasta varchar(60)
as
begin

select * from Pagos where Fecha BETWEEN  @desde and @hasta

 
end
GO
/****** Object:  StoredProcedure [dbo].[PrestamosCliente]    Script Date: 17/06/2022 16:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PrestamosCliente]
@Cliente varchar(60)
as
begin

select * from Prestamos where Cliente = @Cliente

 
end
GO
/****** Object:  StoredProcedure [dbo].[PrestamosFecha]    Script Date: 17/06/2022 16:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PrestamosFecha]
@Fecha varchar(60)
as
begin

select * from Prestamos where Fecha = @Fecha


end
GO
USE [master]
GO
ALTER DATABASE [PruebasFinal1] SET  READ_WRITE 
GO
