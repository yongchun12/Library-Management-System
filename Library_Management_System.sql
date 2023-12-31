USE [master]
GO
/****** Object:  Database [Library Management System]    Script Date: 30/9/2023 4:32:49 PM ******/
CREATE DATABASE [Library Management System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Library Management System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Library Management System.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Library Management System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Library Management System_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Library Management System] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Library Management System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Library Management System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Library Management System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Library Management System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Library Management System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Library Management System] SET ARITHABORT OFF 
GO
ALTER DATABASE [Library Management System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Library Management System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Library Management System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Library Management System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Library Management System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Library Management System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Library Management System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Library Management System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Library Management System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Library Management System] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Library Management System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Library Management System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Library Management System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Library Management System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Library Management System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Library Management System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Library Management System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Library Management System] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Library Management System] SET  MULTI_USER 
GO
ALTER DATABASE [Library Management System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Library Management System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Library Management System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Library Management System] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Library Management System] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Library Management System] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Library Management System] SET QUERY_STORE = ON
GO
ALTER DATABASE [Library Management System] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Library Management System]
GO
/****** Object:  Table [dbo].[AdminUser]    Script Date: 30/9/2023 4:32:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminUser](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
	[name] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[phone_number] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 30/9/2023 4:32:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[books_name] [varchar](50) NULL,
	[bookID] [varchar](50) NULL,
	[books_authorName] [varchar](50) NULL,
	[books_quantity] [varbinary](50) NULL,
	[books_category] [varchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[AdminUser] ([username], [password], [name], [email], [phone_number]) VALUES (N'admin', N'admin', NULL, NULL, NULL)
INSERT [dbo].[AdminUser] ([username], [password], [name], [email], [phone_number]) VALUES (N'yongchun', N'Chun070137', N'Yong Chun', N'yongchun_sam@hotmail.com', 175899666)
GO
USE [master]
GO
ALTER DATABASE [Library Management System] SET  READ_WRITE 
GO
