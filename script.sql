USE [master]
GO
/****** Object:  Database [KWVideo]    Script Date: 2/03/2020 6:19:13 AM ******/
CREATE DATABASE [KWVideo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KWVideo_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\KWVideo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'KWVideo_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\KWVideo.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [KWVideo] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KWVideo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KWVideo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KWVideo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KWVideo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KWVideo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KWVideo] SET ARITHABORT OFF 
GO
ALTER DATABASE [KWVideo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KWVideo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KWVideo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KWVideo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KWVideo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KWVideo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KWVideo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KWVideo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KWVideo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KWVideo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KWVideo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KWVideo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KWVideo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KWVideo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KWVideo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KWVideo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KWVideo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KWVideo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KWVideo] SET  MULTI_USER 
GO
ALTER DATABASE [KWVideo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KWVideo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KWVideo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KWVideo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KWVideo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KWVideo] SET QUERY_STORE = OFF
GO
USE [KWVideo]
GO
/****** Object:  Table [dbo].[CustomerRecord]    Script Date: 2/03/2020 6:19:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerRecord](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CName] [varchar](50) NULL,
	[CPlace] [varchar](50) NULL,
	[CContact] [varchar](50) NULL,
 CONSTRAINT [PK_CustomerRecord] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentRecord]    Script Date: 2/03/2020 6:19:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentRecord](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CId] [int] NULL,
	[VId] [int] NULL,
	[IssueDate] [varchar](50) NULL,
	[ReturnDate] [varchar](50) NULL,
 CONSTRAINT [PK_RentRecord] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VideoRecord]    Script Date: 2/03/2020 6:19:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VideoRecord](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VName] [varchar](50) NULL,
	[VRatting] [varchar](50) NULL,
	[VYear] [int] NULL,
	[VCopies] [int] NULL,
	[VPlot] [varchar](50) NULL,
	[VGenre] [varchar](50) NULL,
	[VCost] [int] NULL,
 CONSTRAINT [PK_VideoRecord] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CustomerRecord] ON 

INSERT [dbo].[CustomerRecord] ([ID], [CName], [CPlace], [CContact]) VALUES (3, N'ba', N'nz', N'78')
SET IDENTITY_INSERT [dbo].[CustomerRecord] OFF
SET IDENTITY_INSERT [dbo].[VideoRecord] ON 

INSERT [dbo].[VideoRecord] ([ID], [VName], [VRatting], [VYear], [VCopies], [VPlot], [VGenre], [VCost]) VALUES (1, N'bahu', N'2.3', 2019, 3, N'as', N'qw', 5)
SET IDENTITY_INSERT [dbo].[VideoRecord] OFF
USE [master]
GO
ALTER DATABASE [KWVideo] SET  READ_WRITE 
GO
