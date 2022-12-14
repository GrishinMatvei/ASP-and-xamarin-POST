USE [master]
GO
/****** Object:  Database [EtoBaza]    Script Date: 13.10.2022 17:11:01 ******/
CREATE DATABASE [EtoBaza]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EtoBaza', FILENAME = N'D:\SQLServ\MSSQL15.SQLEXPRESS\MSSQL\DATA\EtoBaza.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EtoBaza_log', FILENAME = N'D:\SQLServ\MSSQL15.SQLEXPRESS\MSSQL\DATA\EtoBaza_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EtoBaza] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EtoBaza].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EtoBaza] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EtoBaza] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EtoBaza] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EtoBaza] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EtoBaza] SET ARITHABORT OFF 
GO
ALTER DATABASE [EtoBaza] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EtoBaza] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EtoBaza] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EtoBaza] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EtoBaza] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EtoBaza] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EtoBaza] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EtoBaza] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EtoBaza] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EtoBaza] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EtoBaza] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EtoBaza] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EtoBaza] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EtoBaza] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EtoBaza] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EtoBaza] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EtoBaza] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EtoBaza] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EtoBaza] SET  MULTI_USER 
GO
ALTER DATABASE [EtoBaza] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EtoBaza] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EtoBaza] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EtoBaza] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EtoBaza] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EtoBaza] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [EtoBaza] SET QUERY_STORE = OFF
GO
USE [EtoBaza]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 13.10.2022 17:11:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[fam] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Users] ([id], [name], [fam]) VALUES (1, N'Matthew', N'Johns')
GO
USE [master]
GO
ALTER DATABASE [EtoBaza] SET  READ_WRITE 
GO
