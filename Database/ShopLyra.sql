USE [master]
GO
/****** Object:  Database [ShopLyra]    Script Date: 7/29/2020 3:56:16 PM ******/
CREATE DATABASE [ShopLyra]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShopLyra', FILENAME = N'G:\ViCoGroup\Database\Data\ShopLyra.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ShopLyra_log', FILENAME = N'G:\ViCoGroup\Database\Data\ShopLyra_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShopLyra].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShopLyra] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShopLyra] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShopLyra] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShopLyra] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShopLyra] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShopLyra] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ShopLyra] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShopLyra] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShopLyra] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShopLyra] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShopLyra] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShopLyra] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShopLyra] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShopLyra] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShopLyra] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ShopLyra] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShopLyra] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShopLyra] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShopLyra] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShopLyra] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShopLyra] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShopLyra] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShopLyra] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ShopLyra] SET  MULTI_USER 
GO
ALTER DATABASE [ShopLyra] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShopLyra] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShopLyra] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShopLyra] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
USE [ShopLyra]
GO
/****** Object:  Table [dbo].[About]    Script Date: 7/29/2020 3:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[About](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[MetaTitle] [varchar](250) NULL,
	[Desciption] [nvarchar](500) NULL,
	[Detail] [ntext] NOT NULL,
	[CreateDate] [date] NULL,
	[CreateBy] [nvarchar](250) NULL,
	[ModifileDate] [date] NULL,
	[ModifileBy] [nvarchar](250) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_About] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Assess]    Script Date: 7/29/2020 3:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assess](
	[IDProduct] [bigint] NOT NULL,
	[IDMember] [bigint] NOT NULL,
	[Title] [nvarchar](250) NOT NULL,
	[ShortContent] [nvarchar](1000) NOT NULL,
	[NumberStar] [int] NULL,
	[Content] [nvarchar](max) NULL,
 CONSTRAINT [PK_Assess] PRIMARY KEY CLUSTERED 
(
	[IDProduct] ASC,
	[IDMember] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CartItem]    Script Date: 7/29/2020 3:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CartItem](
	[IDCart] [bigint] NOT NULL,
	[IDProduct] [bigint] NOT NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](18, 0) NULL,
	[InsertDate] [date] NULL,
 CONSTRAINT [PK_CartItem] PRIMARY KEY CLUSTERED 
(
	[IDCart] ASC,
	[IDProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Color]    Script Date: 7/29/2020 3:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Color](
	[ID] [int] NOT NULL,
	[Color] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Config]    Script Date: 7/29/2020 3:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Config](
	[ID] [int] NOT NULL,
	[Phone] [varchar](12) NULL,
	[ContentFooter] [nvarchar](1000) NULL,
	[Address] [nvarchar](max) NULL,
	[LinkFast] [nvarchar](500) NULL,
	[FacebookFanpage] [varchar](500) NULL,
	[CreateDate] [date] NULL,
	[CreateBy] [nvarchar](250) NULL,
	[ModifileDate] [date] NULL,
	[ModifileBy] [nvarchar](250) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Config] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 7/29/2020 3:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Content] [ntext] NOT NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FeedBack]    Script Date: 7/29/2020 3:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FeedBack](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[MetaTitle] [varchar](250) NULL,
	[TitleContent] [nvarchar](50) NOT NULL,
	[ShortNote] [nvarchar](1000) NOT NULL,
	[Content] [ntext] NOT NULL,
	[Active] [bit] NULL,
	[Hot] [bit] NULL,
	[DisplayOrder] [int] NULL,
 CONSTRAINT [PK_FeedBack] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 7/29/2020 3:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[ID] [bigint] NOT NULL,
	[Account] [varchar](32) NOT NULL,
	[Pssword] [varchar](500) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Phone] [varchar](12) NOT NULL,
	[Email] [varchar](250) NOT NULL,
	[Address] [varchar](250) NULL,
	[IDCategory] [int] NOT NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemberCategories]    Script Date: 7/29/2020 3:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberCategories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_MemberCategories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 7/29/2020 3:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Url] [varchar](250) NOT NULL,
	[Active] [bit] NULL,
	[ShowOnHome] [bit] NULL,
	[DisplayOrder] [int] NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuItem]    Script Date: 7/29/2020 3:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuItem](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDMenu] [int] NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Url] [varchar](250) NOT NULL,
	[Active] [bit] NULL,
	[DisplayOrder] [int] NULL,
 CONSTRAINT [PK_MenuItem] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItem]    Script Date: 7/29/2020 3:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItem](
	[IDOrder] [bigint] NOT NULL,
	[IDProduct] [bigint] NOT NULL,
	[QuantityPurchased] [int] NOT NULL,
	[Price] [decimal](18, 0) NULL,
 CONSTRAINT [PK_OrderItem] PRIMARY KEY CLUSTERED 
(
	[IDOrder] ASC,
	[IDProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 7/29/2020 3:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [bigint] NOT NULL,
	[IdMember] [bigint] NOT NULL,
	[CreateDate] [date] NULL,
	[CreateBy] [nvarchar](250) NULL,
	[Price] [decimal](18, 0) NULL,
	[Payment] [int] NULL,
	[ShipDate] [date] NULL,
	[ShipBy] [nvarchar](250) NULL,
	[Status] [bit] NULL,
	[Remove] [bit] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 7/29/2020 3:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[ID] [bigint] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[MetaTitle] [varchar](250) NULL,
	[Description] [nvarchar](500) NULL,
	[Images] [varchar](max) NOT NULL,
	[TagID] [bigint] NOT NULL,
	[Detail] [ntext] NOT NULL,
	[CreateDate] [date] NULL,
	[CreateBy] [nvarchar](100) NULL,
	[Modifiledate] [date] NULL,
	[ModifileBy] [nvarchar](100) NULL,
	[Active] [bit] NULL,
	[ShowOnHome] [bit] NULL,
	[HotPost] [bit] NULL,
	[Delete] [bit] NULL,
 CONSTRAINT [PK_Post] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostCategories]    Script Date: 7/29/2020 3:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostCategories](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[MetaTitle] [varchar](250) NULL,
	[DisplayOrder] [int] NULL,
	[CreateDate] [date] NULL,
	[CreateBy] [nvarchar](100) NULL,
	[Modifiledate] [date] NULL,
	[ModifileBy] [nvarchar](100) NULL,
	[Active] [bit] NULL,
	[ShowOnHome] [bit] NULL,
 CONSTRAINT [PK_PostCategories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 7/29/2020 3:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[MetaTitle] [varchar](250) NULL,
	[Code] [varchar](20) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[Images] [varchar](max) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Quantity] [int] NULL,
	[SupplierID] [int] NOT NULL,
	[Detail] [ntext] NOT NULL,
	[Warranty] [int] NULL,
	[CreateDate] [date] NULL,
	[CreateBy] [nvarchar](100) NULL,
	[Modifiledate] [date] NULL,
	[ModifileBy] [nvarchar](100) NULL,
	[Status] [bit] NULL,
	[Active] [bit] NULL,
	[ShowOnHome] [bit] NULL,
	[HotProduct] [bit] NULL,
	[Delete] [bit] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCarts]    Script Date: 7/29/2020 3:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCarts](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[CreateBy] [bigint] NOT NULL,
	[Price] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ProductCarts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategories]    Script Date: 7/29/2020 3:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategories](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[MetaTitle] [varchar](250) NULL,
	[DisplayOrder] [int] NULL,
	[SeoTitle] [nvarchar](250) NULL,
	[CreateDate] [date] NULL,
	[CreateBy] [nvarchar](100) NULL,
	[Modifiledate] [date] NULL,
	[ModifileBy] [nvarchar](100) NULL,
	[Active] [bit] NULL,
	[ShowOnHome] [bit] NULL,
 CONSTRAINT [PK_ProductCategories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Size]    Script Date: 7/29/2020 3:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Size](
	[ID] [int] NOT NULL,
	[Size] [varchar](5) NOT NULL,
 CONSTRAINT [PK_Size] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sliders]    Script Date: 7/29/2020 3:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sliders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Image] [varchar](250) NOT NULL,
	[Title] [nvarchar](250) NULL,
	[MetaTitle] [varchar](250) NULL,
	[ShortContent] [nvarchar](500) NULL,
	[Content] [ntext] NULL,
	[Url] [varchar](250) NOT NULL,
	[CreateDate] [date] NULL,
	[CreateBy] [nvarchar](100) NULL,
	[Modifiledate] [date] NULL,
	[ModifileBy] [nvarchar](100) NULL,
	[Active] [bit] NULL,
	[DisplayOrder] [int] NULL,
	[Location] [int] NULL,
	[Hot] [bit] NULL,
 CONSTRAINT [PK_Sliders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 7/29/2020 3:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Alias] [varchar](100) NULL,
	[Phone] [varchar](15) NOT NULL,
	[Email] [varchar](250) NOT NULL,
	[Image] [varchar](250) NOT NULL,
	[Logo] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TagCategory]    Script Date: 7/29/2020 3:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TagCategory](
	[CategoryID] [bigint] NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_TagCategory] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TagPost]    Script Date: 7/29/2020 3:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TagPost](
	[CategoryID] [bigint] NOT NULL,
	[PostID] [bigint] NOT NULL,
	[Active] [bit] NULL,
	[TagName] [nvarchar](50) NULL,
 CONSTRAINT [PK_TagPost] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC,
	[PostID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TagSize_Color]    Script Date: 7/29/2020 3:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TagSize_Color](
	[IDProduct] [bigint] NOT NULL,
	[IDSize] [int] NOT NULL,
	[IDColor] [int] NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_TagSize_Color] PRIMARY KEY CLUSTERED 
(
	[IDProduct] ASC,
	[IDSize] ASC,
	[IDColor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[About] ADD  CONSTRAINT [DF_About_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[About] ADD  CONSTRAINT [DF_About_ModifileDate]  DEFAULT (getdate()) FOR [ModifileDate]
GO
ALTER TABLE [dbo].[About] ADD  CONSTRAINT [DF_About_Active]  DEFAULT ((0)) FOR [Active]
GO
ALTER TABLE [dbo].[Assess] ADD  CONSTRAINT [DF_Assess_NumberStar]  DEFAULT ((5)) FOR [NumberStar]
GO
ALTER TABLE [dbo].[CartItem] ADD  CONSTRAINT [DF_CartItem_Quantity]  DEFAULT ((1)) FOR [Quantity]
GO
ALTER TABLE [dbo].[CartItem] ADD  CONSTRAINT [DF_CartItem_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[CartItem] ADD  CONSTRAINT [DF_CartItem_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Config] ADD  CONSTRAINT [DF_Config_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Config] ADD  CONSTRAINT [DF_Config_ModifileDate]  DEFAULT (getdate()) FOR [ModifileDate]
GO
ALTER TABLE [dbo].[Config] ADD  CONSTRAINT [DF_Config_Active]  DEFAULT ((0)) FOR [Active]
GO
ALTER TABLE [dbo].[Contact] ADD  CONSTRAINT [DF_Contact_Active]  DEFAULT ((0)) FOR [Active]
GO
ALTER TABLE [dbo].[FeedBack] ADD  CONSTRAINT [DF_FeedBack_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[FeedBack] ADD  CONSTRAINT [DF_FeedBack_Hot]  DEFAULT ((1)) FOR [Hot]
GO
ALTER TABLE [dbo].[FeedBack] ADD  CONSTRAINT [DF_FeedBack_DisplayOrder]  DEFAULT ((1)) FOR [DisplayOrder]
GO
ALTER TABLE [dbo].[MemberCategories] ADD  CONSTRAINT [DF_MemberCategories_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Menu] ADD  CONSTRAINT [DF_Menu_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Menu] ADD  CONSTRAINT [DF_Menu_ShowOnHome]  DEFAULT ((1)) FOR [ShowOnHome]
GO
ALTER TABLE [dbo].[Menu] ADD  CONSTRAINT [DF_Menu_DisplayOrder]  DEFAULT ((1)) FOR [DisplayOrder]
GO
ALTER TABLE [dbo].[MenuItem] ADD  CONSTRAINT [DF_MenuItem_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[MenuItem] ADD  CONSTRAINT [DF_MenuItem_DisplayOrder]  DEFAULT ((1)) FOR [DisplayOrder]
GO
ALTER TABLE [dbo].[OrderItem] ADD  CONSTRAINT [DF_OrderItem_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_Payment]  DEFAULT ((1)) FOR [Payment]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_Remove]  DEFAULT ((0)) FOR [Remove]
GO
ALTER TABLE [dbo].[Post] ADD  CONSTRAINT [DF_Post_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Post] ADD  CONSTRAINT [DF_Post_Modifiledate]  DEFAULT (getdate()) FOR [Modifiledate]
GO
ALTER TABLE [dbo].[Post] ADD  CONSTRAINT [DF_Post_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Post] ADD  CONSTRAINT [DF_Post_ShowOnHome]  DEFAULT ((1)) FOR [ShowOnHome]
GO
ALTER TABLE [dbo].[Post] ADD  CONSTRAINT [DF_Post_HotProduct]  DEFAULT ((0)) FOR [HotPost]
GO
ALTER TABLE [dbo].[PostCategories] ADD  CONSTRAINT [DF_PostCategories_DisplayOrder]  DEFAULT ((1)) FOR [DisplayOrder]
GO
ALTER TABLE [dbo].[PostCategories] ADD  CONSTRAINT [DF_PostCategories_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[PostCategories] ADD  CONSTRAINT [DF_PostCategories_Modifiledate]  DEFAULT (getdate()) FOR [Modifiledate]
GO
ALTER TABLE [dbo].[PostCategories] ADD  CONSTRAINT [DF_PostCategories_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[PostCategories] ADD  CONSTRAINT [DF_PostCategories_ShowOnHome]  DEFAULT ((1)) FOR [ShowOnHome]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Modifiledate]  DEFAULT (getdate()) FOR [Modifiledate]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_ShowOnHome]  DEFAULT ((1)) FOR [ShowOnHome]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_HotProduct]  DEFAULT ((0)) FOR [HotProduct]
GO
ALTER TABLE [dbo].[ProductCarts] ADD  CONSTRAINT [DF_ProductCarts_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[ProductCategories] ADD  CONSTRAINT [DF_ProductCategories_DisplayOrder]  DEFAULT ((1)) FOR [DisplayOrder]
GO
ALTER TABLE [dbo].[ProductCategories] ADD  CONSTRAINT [DF_ProductCategories_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[ProductCategories] ADD  CONSTRAINT [DF_ProductCategories_Modifiledate]  DEFAULT (getdate()) FOR [Modifiledate]
GO
ALTER TABLE [dbo].[ProductCategories] ADD  CONSTRAINT [DF_ProductCategories_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[ProductCategories] ADD  CONSTRAINT [DF_ProductCategories_ShowOnHome]  DEFAULT ((1)) FOR [ShowOnHome]
GO
ALTER TABLE [dbo].[Sliders] ADD  CONSTRAINT [DF_Sliders_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Sliders] ADD  CONSTRAINT [DF_Sliders_Modifiledate]  DEFAULT (getdate()) FOR [Modifiledate]
GO
ALTER TABLE [dbo].[Sliders] ADD  CONSTRAINT [DF_Sliders_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Sliders] ADD  CONSTRAINT [DF_Sliders_DisplayOrder]  DEFAULT ((1)) FOR [DisplayOrder]
GO
ALTER TABLE [dbo].[Sliders] ADD  CONSTRAINT [DF_Sliders_Location]  DEFAULT ((1)) FOR [Location]
GO
ALTER TABLE [dbo].[Sliders] ADD  CONSTRAINT [DF_Sliders_Hot]  DEFAULT ((1)) FOR [Hot]
GO
ALTER TABLE [dbo].[TagPost] ADD  CONSTRAINT [DF_TagPost_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Assess]  WITH CHECK ADD  CONSTRAINT [FK_Assess_Member] FOREIGN KEY([IDProduct])
REFERENCES [dbo].[Member] ([ID])
GO
ALTER TABLE [dbo].[Assess] CHECK CONSTRAINT [FK_Assess_Member]
GO
ALTER TABLE [dbo].[Assess]  WITH CHECK ADD  CONSTRAINT [FK_Assess_Product] FOREIGN KEY([IDProduct])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[Assess] CHECK CONSTRAINT [FK_Assess_Product]
GO
ALTER TABLE [dbo].[CartItem]  WITH CHECK ADD  CONSTRAINT [FK_CartItem_Product] FOREIGN KEY([IDProduct])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[CartItem] CHECK CONSTRAINT [FK_CartItem_Product]
GO
ALTER TABLE [dbo].[CartItem]  WITH CHECK ADD  CONSTRAINT [FK_CartItem_ProductCarts] FOREIGN KEY([IDCart])
REFERENCES [dbo].[ProductCarts] ([ID])
GO
ALTER TABLE [dbo].[CartItem] CHECK CONSTRAINT [FK_CartItem_ProductCarts]
GO
ALTER TABLE [dbo].[Member]  WITH CHECK ADD  CONSTRAINT [FK_Member_MemberCategories] FOREIGN KEY([IDCategory])
REFERENCES [dbo].[MemberCategories] ([ID])
GO
ALTER TABLE [dbo].[Member] CHECK CONSTRAINT [FK_Member_MemberCategories]
GO
ALTER TABLE [dbo].[MenuItem]  WITH CHECK ADD  CONSTRAINT [FK_MenuItem_Menu] FOREIGN KEY([IDMenu])
REFERENCES [dbo].[Menu] ([ID])
GO
ALTER TABLE [dbo].[MenuItem] CHECK CONSTRAINT [FK_MenuItem_Menu]
GO
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_Orders] FOREIGN KEY([IDOrder])
REFERENCES [dbo].[Orders] ([ID])
GO
ALTER TABLE [dbo].[OrderItem] CHECK CONSTRAINT [FK_OrderItem_Orders]
GO
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_Product] FOREIGN KEY([IDProduct])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[OrderItem] CHECK CONSTRAINT [FK_OrderItem_Product]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Member] FOREIGN KEY([IdMember])
REFERENCES [dbo].[Member] ([ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Member]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Supplier] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Supplier]
GO
ALTER TABLE [dbo].[ProductCarts]  WITH CHECK ADD  CONSTRAINT [FK_ProductCarts_Member] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[Member] ([ID])
GO
ALTER TABLE [dbo].[ProductCarts] CHECK CONSTRAINT [FK_ProductCarts_Member]
GO
ALTER TABLE [dbo].[TagCategory]  WITH CHECK ADD  CONSTRAINT [FK_TagCategory_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[TagCategory] CHECK CONSTRAINT [FK_TagCategory_Product]
GO
ALTER TABLE [dbo].[TagCategory]  WITH CHECK ADD  CONSTRAINT [FK_TagCategory_ProductCategories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[ProductCategories] ([ID])
GO
ALTER TABLE [dbo].[TagCategory] CHECK CONSTRAINT [FK_TagCategory_ProductCategories]
GO
ALTER TABLE [dbo].[TagPost]  WITH CHECK ADD  CONSTRAINT [FK_TagPost_Post] FOREIGN KEY([PostID])
REFERENCES [dbo].[Post] ([ID])
GO
ALTER TABLE [dbo].[TagPost] CHECK CONSTRAINT [FK_TagPost_Post]
GO
ALTER TABLE [dbo].[TagPost]  WITH CHECK ADD  CONSTRAINT [FK_TagPost_PostCategories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[PostCategories] ([ID])
GO
ALTER TABLE [dbo].[TagPost] CHECK CONSTRAINT [FK_TagPost_PostCategories]
GO
ALTER TABLE [dbo].[TagSize_Color]  WITH CHECK ADD  CONSTRAINT [FK_TagSize_Color_Color] FOREIGN KEY([IDColor])
REFERENCES [dbo].[Color] ([ID])
GO
ALTER TABLE [dbo].[TagSize_Color] CHECK CONSTRAINT [FK_TagSize_Color_Color]
GO
ALTER TABLE [dbo].[TagSize_Color]  WITH CHECK ADD  CONSTRAINT [FK_TagSize_Color_Product] FOREIGN KEY([IDProduct])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[TagSize_Color] CHECK CONSTRAINT [FK_TagSize_Color_Product]
GO
ALTER TABLE [dbo].[TagSize_Color]  WITH CHECK ADD  CONSTRAINT [FK_TagSize_Color_Size] FOREIGN KEY([IDSize])
REFERENCES [dbo].[Size] ([ID])
GO
ALTER TABLE [dbo].[TagSize_Color] CHECK CONSTRAINT [FK_TagSize_Color_Size]
GO
USE [master]
GO
ALTER DATABASE [ShopLyra] SET  READ_WRITE 
GO
