USE [QuanLyMyPham]
GO
/****** Object:  Table [dbo].[bill]    Script Date: 9/8/2021 12:57:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bill](
	[id] [int] NOT NULL,
	[userbuy] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](50) NULL,
	[total] [nvarchar](50) NULL,
 CONSTRAINT [PK_bill] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[category]    Script Date: 9/8/2021 12:57:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 9/8/2021 12:57:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 9/8/2021 12:57:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[categoryId] [int] NULL,
	[price] [float] NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[category] ([id], [name]) VALUES (1, N'Son')
INSERT [dbo].[category] ([id], [name]) VALUES (2, N'Phấn')
INSERT [dbo].[category] ([id], [name]) VALUES (3, N'Mặt nạ')
INSERT [dbo].[category] ([id], [name]) VALUES (4, N'Sữa rửa mặt')
INSERT [dbo].[category] ([id], [name]) VALUES (5, N'Sơn móng tay')
GO
INSERT [dbo].[login] ([username], [password]) VALUES (N'admin', N'admin')
GO
SET IDENTITY_INSERT [dbo].[product] ON 

INSERT [dbo].[product] ([id], [name], [categoryId], [price]) VALUES (1, N'SON1', 1, 100)
INSERT [dbo].[product] ([id], [name], [categoryId], [price]) VALUES (2, N'son2', 1, 200)
INSERT [dbo].[product] ([id], [name], [categoryId], [price]) VALUES (3, N'phấn 1', 2, 253)
INSERT [dbo].[product] ([id], [name], [categoryId], [price]) VALUES (4, N'phấn 2', 2, 412)
INSERT [dbo].[product] ([id], [name], [categoryId], [price]) VALUES (5, N'mặt nạ 1', 3, 51)
INSERT [dbo].[product] ([id], [name], [categoryId], [price]) VALUES (6, N'mặt nạ 2', 3, 54)
INSERT [dbo].[product] ([id], [name], [categoryId], [price]) VALUES (7, N'sữa rửa mặt', 4, 99)
INSERT [dbo].[product] ([id], [name], [categoryId], [price]) VALUES (8, N'sữa rửa mặt AA', 4, 98)
INSERT [dbo].[product] ([id], [name], [categoryId], [price]) VALUES (9, N'sơn móng tay xanh', 5, 123)
INSERT [dbo].[product] ([id], [name], [categoryId], [price]) VALUES (10, N'sơn móng đỏ', 5, 312)
INSERT [dbo].[product] ([id], [name], [categoryId], [price]) VALUES (11, N'Son3', 1, 999)
INSERT [dbo].[product] ([id], [name], [categoryId], [price]) VALUES (16, N'Tên s?n ph?m:', 4, 43)
INSERT [dbo].[product] ([id], [name], [categoryId], [price]) VALUES (17, N'ewr', 3, 34)
INSERT [dbo].[product] ([id], [name], [categoryId], [price]) VALUES (19, N'S?a r?a m?t cam', 4, 434)
SET IDENTITY_INSERT [dbo].[product] OFF
GO
