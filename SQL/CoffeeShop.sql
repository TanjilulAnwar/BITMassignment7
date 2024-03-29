USE [CoffeeShop]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 01-Oct-19 12:17:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NULL,
	[Phone] [varchar](15) NULL,
	[AddressNo] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 01-Oct-19 12:17:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[price] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 01-Oct-19 12:17:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](30) NULL,
	[ItemName] [varchar](30) NULL,
	[Quantity] [int] NULL,
	[TotalPrice] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[customers] ON 

INSERT [dbo].[customers] ([ID], [Name], [Phone], [AddressNo]) VALUES (1, N'karim', N'01245826', N'Karwan Bazar')
INSERT [dbo].[customers] ([ID], [Name], [Phone], [AddressNo]) VALUES (2, N'Rahim', N'01749795', N'Farm Gate')
INSERT [dbo].[customers] ([ID], [Name], [Phone], [AddressNo]) VALUES (3, N'Jalil', N'01256452', N'Pantha Path')
INSERT [dbo].[customers] ([ID], [Name], [Phone], [AddressNo]) VALUES (4, N'Sagir', N'01458453', N'Mirpur')
INSERT [dbo].[customers] ([ID], [Name], [Phone], [AddressNo]) VALUES (6, N'Harun', N'48984284', N'Jatrabari')
SET IDENTITY_INSERT [dbo].[customers] OFF
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([ID], [Name], [price]) VALUES (1, N'Black ', 120)
INSERT [dbo].[Items] ([ID], [Name], [price]) VALUES (2, N'Cold', 100)
INSERT [dbo].[Items] ([ID], [Name], [price]) VALUES (3, N'Hot', 130)
INSERT [dbo].[Items] ([ID], [Name], [price]) VALUES (4, N'Latte', 200)
INSERT [dbo].[Items] ([ID], [Name], [price]) VALUES (5, N'Delights', 140)
INSERT [dbo].[Items] ([ID], [Name], [price]) VALUES (6, N'Broke', 78)
SET IDENTITY_INSERT [dbo].[Items] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([id], [CustomerName], [ItemName], [Quantity], [TotalPrice]) VALUES (4, N'Didar', N'Choco Fuzz', 2, 200)
INSERT [dbo].[Orders] ([id], [CustomerName], [ItemName], [Quantity], [TotalPrice]) VALUES (2, N'Harun', N'Delight', 6, 200)
INSERT [dbo].[Orders] ([id], [CustomerName], [ItemName], [Quantity], [TotalPrice]) VALUES (3, N'Jaker', N'Choco Fuzz', 3, 150)
SET IDENTITY_INSERT [dbo].[Orders] OFF
