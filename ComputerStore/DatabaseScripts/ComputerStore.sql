USE [master]
GO
/****** Object:  Database [ComputerStore]    Script Date: 6/4/2016 11:42:40 AM ******/
CREATE DATABASE [ComputerStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ComputerStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ComputerStore.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ComputerStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ComputerStore_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ComputerStore] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ComputerStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ComputerStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ComputerStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ComputerStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ComputerStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ComputerStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [ComputerStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ComputerStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ComputerStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ComputerStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ComputerStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ComputerStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ComputerStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ComputerStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ComputerStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ComputerStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ComputerStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ComputerStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ComputerStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ComputerStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ComputerStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ComputerStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ComputerStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ComputerStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ComputerStore] SET  MULTI_USER 
GO
ALTER DATABASE [ComputerStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ComputerStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ComputerStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ComputerStore] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ComputerStore] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ComputerStore]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 6/4/2016 11:42:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[IdCustomer] [int] IDENTITY(1,1) NOT NULL,
	[FirstNameCustomer] [nvarchar](50) NOT NULL,
	[LastNameCustomer] [nvarchar](50) NOT NULL,
	[ID] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[IdCustomer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employees]    Script Date: 6/4/2016 11:42:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[IdEmployee] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[IdTitle] [int] NULL,
	[IsActive] [bit] NOT NULL CONSTRAINT [DF_Employees_IsActive]  DEFAULT ((1)),
	[IdPerson] [nvarchar](50) NULL,
	[CellPhone] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[IdEmployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderItems]    Script Date: 6/4/2016 11:42:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItems](
	[IdOrderItem] [int] IDENTITY(1,1) NOT NULL,
	[IdOrder] [int] NOT NULL,
	[IdProduct] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[OrderItemPrice] [money] NOT NULL,
 CONSTRAINT [PK_OrderItems] PRIMARY KEY CLUSTERED 
(
	[IdOrderItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 6/4/2016 11:42:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[IdOrder] [int] IDENTITY(1,1) NOT NULL,
	[DateOrder] [datetime] NULL,
	[CashRegister] [int] NOT NULL,
	[PriceOrder] [money] NOT NULL,
	[IdEmployee] [int] NOT NULL CONSTRAINT [DF__Orders__new_col__2F10007B]  DEFAULT ((4)),
	[Details] [nvarchar](100) NULL CONSTRAINT [DF__Orders__Details__31EC6D26]  DEFAULT (NULL),
	[IdCustomer] [int] NOT NULL DEFAULT ((2)),
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[IdOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 6/4/2016 11:42:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[IdProduct] [int] IDENTITY(1,1) NOT NULL,
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
	[IdProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Titles]    Script Date: 6/4/2016 11:42:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Titles](
	[IdTitle] [int] NOT NULL,
	[TitleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED 
(
	[IdTitle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UnqTitleName]    Script Date: 6/4/2016 11:42:40 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UnqTitleName] ON [dbo].[Titles]
(
	[TitleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Titles] FOREIGN KEY([IdTitle])
REFERENCES [dbo].[Titles] ([IdTitle])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Titles]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Orders] FOREIGN KEY([IdOrder])
REFERENCES [dbo].[Orders] ([IdOrder])
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Orders]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Product] FOREIGN KEY([IdProduct])
REFERENCES [dbo].[Product] ([IdProduct])
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Product]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([IdCustomer])
REFERENCES [dbo].[Customers] ([IdCustomer])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([IdEmployee])
REFERENCES [dbo].[Employees] ([IdEmployee])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ukupna cena stavke = cena proizvoda * kolicina' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OrderItems', @level2type=N'COLUMN',@level2name=N'OrderItemPrice'
GO
USE [master]
GO
ALTER DATABASE [ComputerStore] SET  READ_WRITE 
GO
