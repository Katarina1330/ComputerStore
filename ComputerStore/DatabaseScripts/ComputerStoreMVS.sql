USE [master]
GO
/****** Object:  Database [ComputerStoreMVC]    Script Date: 6/4/2016 11:43:58 AM ******/
CREATE DATABASE [ComputerStoreMVC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ComputerStoreMVC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ComputerStoreMVC.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ComputerStoreMVC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ComputerStoreMVC_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ComputerStoreMVC] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ComputerStoreMVC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ComputerStoreMVC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET ARITHABORT OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ComputerStoreMVC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ComputerStoreMVC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ComputerStoreMVC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ComputerStoreMVC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ComputerStoreMVC] SET  MULTI_USER 
GO
ALTER DATABASE [ComputerStoreMVC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ComputerStoreMVC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ComputerStoreMVC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ComputerStoreMVC] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ComputerStoreMVC] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ComputerStoreMVC]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 6/4/2016 11:43:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstNameCustomer] [nvarchar](50) NOT NULL,
	[LastNameCustomer] [nvarchar](50) NOT NULL,
	[SSN] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employees]    Script Date: 6/4/2016 11:43:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[IdTitle] [int] NULL,
	[IsActive] [bit] NOT NULL CONSTRAINT [DF_Employees_IsActive]  DEFAULT ((1)),
	[CellPhone] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderProduct]    Script Date: 6/4/2016 11:43:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderProduct](
	[IdOrder] [int] NOT NULL,
	[IdProduct] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 6/4/2016 11:43:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DateOrder] [datetime] NULL,
	[CashRegister] [int] NOT NULL,
	[PriceOrder] [money] NOT NULL,
	[IdEmployee] [int] NOT NULL CONSTRAINT [DF__Orders__new_col__2F10007B]  DEFAULT ((4)),
	[Details] [nvarchar](100) NULL CONSTRAINT [DF__Orders__Details__31EC6D26]  DEFAULT (NULL),
	[IdCustomer] [int] NOT NULL DEFAULT ((2)),
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 6/4/2016 11:43:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameProduct] [nvarchar](50) NOT NULL,
	[PriceProduct] [money] NOT NULL,
	[Description] [nvarchar](50) NULL,
	[Brand] [nvarchar](50) NULL,
	[InStore] [bit] NOT NULL CONSTRAINT [DF_Product_IsActive]  DEFAULT ((1)),
	[MadeIn] [nchar](10) NULL,
	[BuyFromCompany] [nvarchar](50) NULL,
	[CellPhoneCompany] [nvarchar](50) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Titles]    Script Date: 6/4/2016 11:43:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Titles](
	[Id] [int] NOT NULL,
	[TitleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UnqTitleName]    Script Date: 6/4/2016 11:43:58 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UnqTitleName] ON [dbo].[Titles]
(
	[TitleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Titles] FOREIGN KEY([IdTitle])
REFERENCES [dbo].[Titles] ([Id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Titles]
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Orders] FOREIGN KEY([IdOrder])
REFERENCES [dbo].[Orders] ([Id])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK_OrderItems_Orders]
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Product] FOREIGN KEY([IdProduct])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK_OrderItems_Product]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([IdCustomer])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([IdEmployee])
REFERENCES [dbo].[Employees] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
USE [master]
GO
ALTER DATABASE [ComputerStoreMVC] SET  READ_WRITE 
GO
