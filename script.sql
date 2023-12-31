USE [IspanPersonalProject_POS]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 2023/9/9 下午 10:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[C_ID] [int] IDENTITY(1,1) NOT NULL,
	[C_Name] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NULL,
	[Email] [nvarchar](50) NULL,
	[Birth] [date] NULL,
	[Point] [int] NULL,
	[Account] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[C_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2023/9/9 下午 10:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[E_ID] [int] IDENTITY(1,1) NOT NULL,
	[E_Name] [nvarchar](100) NULL,
	[E_Account] [nvarchar](100) NULL,
	[E_Password] [nvarchar](100) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[E_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menulist]    Script Date: 2023/9/9 下午 10:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menulist](
	[List_ID] [int] NOT NULL,
	[Seq] [int] IDENTITY(1,1) NOT NULL,
	[ChName] [nvarchar](50) NULL,
	[EngName] [nvarchar](50) NULL,
 CONSTRAINT [PK_menulist] PRIMARY KEY CLUSTERED 
(
	[List_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orderdetail]    Script Date: 2023/9/9 下午 10:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderdetail](
	[O_ID] [int] NULL,
	[P_ID] [int] NULL,
	[Quantity] [int] NULL,
	[Subtotal] [int] NULL,
	[Sugar] [nvarchar](50) NULL,
	[Ice] [nvarchar](50) NULL,
	[Espresso] [bit] NULL,
	[OrderDetail_ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_orderdetail] PRIMARY KEY CLUSTERED 
(
	[OrderDetail_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 2023/9/9 下午 10:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[O_ID] [int] NOT NULL,
	[C_ID] [int] NULL,
	[OrderDate] [datetime] NULL,
	[PaymentMethod] [nvarchar](50) NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[O_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 2023/9/9 下午 10:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[P_ID] [int] IDENTITY(1,1) NOT NULL,
	[P_Name] [nvarchar](100) NULL,
	[Price] [int] NULL,
	[P_Desc] [nvarchar](1000) NULL,
	[P_Image] [nvarchar](100) NULL,
	[List_ID] [int] NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (1, N'蕭敬騰', N'0912-345-679', N'台中市清水區', N'amber6541@gmail.com', CAST(N'1982-06-09' AS Date), 8490, N'aaa1', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (3, N'徐熙娣', N'0977-555-999', N'高雄市鼓山區', N'rogers9086@gmail.com', CAST(N'1978-06-14' AS Date), 2000, N'aaa3', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (4, N'炎亞綸', N'0988-111-666', N'台南市仁德區', N'leilani8173@outlook.com', CAST(N'1985-11-20' AS Date), 1500, N'aaa4', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (5, N'汪小菲', N'0955-555-555', N'桃園市龜山區', N'haye2560@yahoo.com', CAST(N'1981-06-27' AS Date), 5000, N'aaa5', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (6, N'吳慷仁', N'0911-222-777', N'台北市信義區', N'hill4328@gmail.com', CAST(N'1966-01-12' AS Date), 1, N'aaa6', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (7, N'艾怡良', N'0922-456-666', N'新北市板橋區', N'oscar8938@gmail.com', CAST(N'1988-08-19' AS Date), 900, N'aaa7', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (8, N'羅志祥', N'0915-654-888', N'台中市北區', N'grant4519@outlook.com', CAST(N'1972-03-30' AS Date), 1200, N'aaa8', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (9, N'陳建州', N'0956-456-111', N'台中市烏日區', N'evelyn6627@gmail.com', CAST(N'1977-05-02' AS Date), 500, N'aaa9', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (10, N'吳宗憲', N'0911-235-888', N'台南市安定區', N'gloria7002@yahoo.com', CAST(N'1962-09-26' AS Date), 800, N'aaa10', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (11, N'周杰倫', N'0944-655-233', N'新竹縣竹北市', N'garland8077@hotmail.com', CAST(N'1995-01-01' AS Date), 900, N'aaa11', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (12, N'蔡依林', N'0955-123-896', N'新北市板橋區', N'sterling5804@icloud.com', CAST(N'1992-05-03' AS Date), 770, N'aaa12', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (13, N'林志玲', N'0945-268-522', N'花蓮縣瑞穗區', N'orrico4056@hotmail.com', CAST(N'1993-08-08' AS Date), 1200, N'aaa13', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (15, N'李榮浩', N'0945-555-604', N'台中市西區', N'kim9474@outlook.com', CAST(N'1955-01-31' AS Date), 990, N'aaa15', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (19, N'楊丞琳', N'09350203', N'新竹', N'jocelyn2734@gmail.com', CAST(N'1984-06-04' AS Date), 5200, N'aaa19', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (20, N'yvonne', N'0955-350-203', N'新竹縣', N'percy4076@gmail.com', CAST(N'1999-01-01' AS Date), 2000, N'zxc123', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (21, N'美珠', N'09955555', N'新竹', N'vanessa1394@icloud.com', CAST(N'1999-07-07' AS Date), 13, N'aaa21', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (2024, N'何彥儀', N'0912345677', N'新竹市', N'bb@gmail.com', CAST(N'1999-07-07' AS Date), 53, N'zxc123', N'zxc123')
SET IDENTITY_INSERT [dbo].[customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([E_ID], [E_Name], [E_Account], [E_Password]) VALUES (1, N'店長', N'0000', N'0000')
INSERT [dbo].[Employees] ([E_ID], [E_Name], [E_Account], [E_Password]) VALUES (2, N'員工1號', N'1111', N'1111')
INSERT [dbo].[Employees] ([E_ID], [E_Name], [E_Account], [E_Password]) VALUES (3, N'員工2號', N'2222', N'2222')
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[menulist] ON 

INSERT [dbo].[menulist] ([List_ID], [Seq], [ChName], [EngName]) VALUES (1, 1, N'咖啡', N'coffee')
INSERT [dbo].[menulist] ([List_ID], [Seq], [ChName], [EngName]) VALUES (2, 2, N'氣泡飲料', N'Fizz')
INSERT [dbo].[menulist] ([List_ID], [Seq], [ChName], [EngName]) VALUES (3, 3, N'鮮奶茶', N'Tea and Flavor Milk')
INSERT [dbo].[menulist] ([List_ID], [Seq], [ChName], [EngName]) VALUES (4, 4, N'甜點', N'Dessert')
SET IDENTITY_INSERT [dbo].[menulist] OFF
GO
SET IDENTITY_INSERT [dbo].[orderdetail] ON 

INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (1, 17, 1, 90, N'0%', N'0%', 0, 138)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (1, 8, 5, 400, N'100%', N'100%', 0, 139)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (1, 1, 2, 160, N'0%', N'0%', 1, 140)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (2, 17, 5, 450, N'0%', N'0%', 0, 142)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (2, 14, 1, 60, N'0%', N'0%', 0, 143)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (5, 16, 1, 85, N'0%', N'0%', 0, 146)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (6, 17, 1, 90, N'0%', N'0%', 0, 154)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (7, 16, 1, 85, N'0%', N'0%', 0, 155)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (8, 15, 1, 80, N'0%', N'0%', 0, 156)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (11, 17, 1, 90, N'0%', N'0%', 0, 159)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (12, 11, 1, 50, N'0%', N'0%', 0, 160)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (13, 1, 1, 60, N'100%', N'100%', 0, 161)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (14, 16, 1, 85, N'0%', N'0%', 0, 162)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (16, 16, 1, 85, N'0%', N'0%', 0, 164)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (17, 17, 1, 90, N'0%', N'0%', 0, 165)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (18, 16, 1, 85, N'0%', N'0%', 0, 166)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (19, 17, 1, 90, N'0%', N'0%', 0, 167)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (21, 17, 1, 90, N'0%', N'0%', 0, 169)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (22, 17, 1, 90, N'0%', N'0%', 0, 170)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (23, 16, 1, 85, N'0%', N'0%', 0, 171)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (24, 16, 1, 85, N'0%', N'0%', 0, 172)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (25, 13, 1, 100, N'40%', N'40%', 0, 173)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (26, 16, 1, 85, N'0%', N'0%', 0, 174)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (28, 17, 1, 90, N'0%', N'0%', 0, 176)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (29, 17, 1, 90, N'0%', N'0%', 0, 177)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (32, 16, 1, 85, N'0%', N'0%', 0, 182)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (33, 17, 1, 90, N'0%', N'0%', 0, 184)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (34, 15, 1, 80, N'0%', N'0%', 0, 185)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (34, 1, 1, 80, N'100%', N'100%', 1, 186)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (36, 17, 1, 90, N'0%', N'0%', 0, 189)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (36, 14, 3, 180, N'0%', N'0%', 0, 190)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (37, 17, 1, 90, N'0%', N'0%', 0, 191)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (38, 1, 1, 80, N'80%', N'80%', 1, 192)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (38, 4, 1, 90, N'0%', N'0%', 0, 193)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (39, 17, 1, 90, N'0%', N'0%', 0, 1134)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (40, 3, 1, 120, N'0%', N'0%', 0, 1135)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (42, 16, 1, 85, N'0%', N'0%', 0, 1136)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (42, 14, 1, 60, N'0%', N'0%', 0, 1137)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (43, 17, 1, 90, N'0%', N'0%', 0, 1138)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (44, 17, 1, 90, N'0%', N'0%', 0, 1139)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (45, 17, 1, 90, N'0%', N'0%', 0, 1140)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (46, 17, 1, 90, N'0%', N'0%', 0, 1141)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (47, 17, 1, 90, N'0%', N'0%', 0, 1142)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (48, 16, 1, 85, N'0%', N'0%', 0, 1143)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (49, 4, 1, 90, N'0%', N'0%', 0, 1144)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (51, 17, 1, 90, N'0%', N'0%', 0, 1145)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (52, 17, 1, 90, N'0%', N'0%', 0, 1146)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (53, 17, 1, 90, N'0%', N'0%', 0, 1147)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (54, 16, 1, 85, N'0%', N'0%', 0, 1148)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (55, 16, 1, 85, N'0%', N'0%', 0, 1149)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (56, 16, 1, 85, N'0%', N'0%', 0, 1150)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (58, 15, 1, 80, N'0%', N'0%', 0, 1152)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (59, 17, 1, 90, N'0%', N'0%', 0, 1153)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (62, 16, 1, 85, N'0%', N'0%', 0, 1156)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (63, 12, 1, 70, N'0%', N'0%', 0, 1157)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (65, 1, 1, 60, N'0%', N'0%', 0, 1159)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (66, 17, 1, 90, N'0%', N'0%', 0, 1160)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (67, 16, 1, 85, N'0%', N'0%', 0, 1161)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (68, 14, 1, 60, N'0%', N'0%', 0, 1162)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (68, 1, 1, 80, N'0%', N'0%', 1, 1163)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (68, 10, 1, 60, N'0%', N'0%', 0, 1164)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (69, 17, 1, 90, N'0%', N'0%', 0, 2164)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (80, 17, 1, 90, N'0%', N'0%', 0, 2180)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (81, 4, 1, 90, N'0%', N'0%', 0, 2182)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (82, 4, 1, 90, N'0%', N'0%', 0, 2190)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (84, 3, 1, 120, N'0%', N'0%', 0, 2192)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (85, 17, 1, 90, N'0%', N'0%', 0, 2193)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (86, 11, 1, 50, N'100%', N'100%', 0, 2194)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (87, 4, 1, 90, N'100%', N'100%', 0, 2195)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (88, 4, 6, 540, N'80%', N'80%', 0, 2199)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (89, 1, 5, 400, N'100%', N'100%', 1, 2200)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (90, 1, 4, 240, N'40%', N'40%', 0, 2201)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (90, 14, 1, 60, N'0%', N'0%', 0, 2202)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (91, 4, 5, 450, N'0%', N'0%', 0, 2203)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (92, 4, 1, 90, N'0%', N'0%', 0, 2204)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (93, 4, 1, 90, N'0%', N'0%', 0, 2205)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (94, 2, 1, 85, N'0%', N'0%', 0, 2206)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (95, 18, 10, 900, N'0%', N'0%', 0, 2207)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (96, 17, 1, 90, N'0%', N'0%', 0, 2208)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (96, 18, 1, 90, N'0%', N'0%', 0, 2209)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (97, 1, 1, 60, N'0%', N'40%', 0, 2219)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (97, 6, 2, 230, N'0%', N'0%', 1, 2220)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (97, 10, 1, 60, N'40%', N'80%', 0, 2222)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (97, 14, 3, 180, N'0%', N'0%', 0, 2223)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (98, 17, 1, 90, N'0%', N'0%', 0, 2224)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (98, 7, 1, 90, N'80%', N'100%', 0, 2225)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (98, 1, 3, 180, N'0%', N'80%', 0, 2226)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (99, 14, 15, 900, N'0%', N'0%', 0, 2227)
SET IDENTITY_INSERT [dbo].[orderdetail] OFF
GO
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (1, 5, CAST(N'2023-06-29T20:46:33.373' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (2, 20, CAST(N'2023-06-29T20:49:10.927' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (5, 11, CAST(N'2023-06-29T21:37:53.810' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (6, 5, CAST(N'2023-06-29T22:10:58.857' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (7, 13, CAST(N'2023-06-29T22:18:23.910' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (8, NULL, CAST(N'2023-06-29T22:24:28.270' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (11, 8, CAST(N'2023-06-29T23:18:07.373' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (12, 9, CAST(N'2023-06-29T23:19:20.797' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (13, 10, CAST(N'2023-06-29T23:23:14.320' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (14, 1, CAST(N'2023-06-29T23:23:57.750' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (16, 1, CAST(N'2023-06-29T23:27:08.850' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (17, 1, CAST(N'2023-06-29T23:31:09.193' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (18, 1, CAST(N'2023-06-29T23:37:34.703' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (19, 12, CAST(N'2023-06-29T23:38:10.407' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (21, 13, CAST(N'2023-06-29T23:53:30.057' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (22, 13, CAST(N'2023-06-29T23:56:17.830' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (23, NULL, CAST(N'2023-06-29T23:57:24.567' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (24, 3, CAST(N'2023-06-29T23:59:48.263' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (25, 21, CAST(N'2023-06-30T00:01:10.793' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (26, 19, CAST(N'2023-06-30T00:03:05.050' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (28, 19, CAST(N'2023-06-30T00:08:53.667' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (29, 19, CAST(N'2023-06-30T00:10:36.883' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (32, 19, CAST(N'2023-06-30T17:09:11.123' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (33, 19, CAST(N'2023-06-30T17:11:36.467' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (34, NULL, CAST(N'2023-06-30T18:14:01.683' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (36, 19, CAST(N'2023-06-30T18:19:36.247' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (37, 19, CAST(N'2023-06-30T18:46:40.507' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (38, 19, CAST(N'2023-06-30T18:47:04.613' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (39, NULL, CAST(N'2023-07-01T15:29:54.387' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (40, NULL, CAST(N'2023-07-01T15:32:26.713' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (42, 11, CAST(N'2023-07-01T15:39:18.027' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (43, NULL, CAST(N'2023-07-01T15:39:55.810' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (44, NULL, CAST(N'2023-07-01T15:43:32.920' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (45, 13, CAST(N'2023-07-01T15:44:52.710' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (46, 15, CAST(N'2023-07-01T15:46:16.163' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (47, 1, CAST(N'2023-07-01T15:47:09.773' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (48, 1, CAST(N'2023-07-01T15:47:58.567' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (49, 5, CAST(N'2023-07-01T15:48:58.640' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (51, 7, CAST(N'2023-07-01T15:50:48.337' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (52, 10, CAST(N'2023-07-01T15:52:40.310' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (53, 12, CAST(N'2023-07-01T15:54:50.997' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (54, NULL, CAST(N'2023-07-01T15:56:57.220' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (55, NULL, CAST(N'2023-07-01T15:58:48.380' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (56, 19, CAST(N'2023-07-01T16:00:53.513' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (58, 21, CAST(N'2023-07-01T16:08:08.653' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (59, 21, CAST(N'2023-07-01T16:08:56.650' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (62, NULL, CAST(N'2023-07-01T16:11:03.643' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (63, 15, CAST(N'2023-07-01T16:22:22.873' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (65, NULL, CAST(N'2023-07-01T16:28:15.987' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (66, NULL, CAST(N'2023-07-01T16:29:41.210' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (67, NULL, CAST(N'2023-07-01T16:30:47.610' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (68, 19, CAST(N'2023-07-01T18:20:52.387' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (69, 20, CAST(N'2023-07-01T20:30:44.970' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (80, NULL, CAST(N'2023-07-01T21:27:20.057' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (81, NULL, CAST(N'2023-07-01T21:29:52.860' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (82, NULL, CAST(N'2023-07-02T00:30:09.277' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (84, NULL, CAST(N'2023-07-02T00:45:48.010' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (85, NULL, CAST(N'2023-07-02T00:50:57.347' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (86, NULL, CAST(N'2023-07-02T00:56:01.627' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (87, NULL, CAST(N'2023-07-02T00:57:28.937' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (88, NULL, CAST(N'2023-07-02T17:16:29.937' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (89, NULL, CAST(N'2023-07-02T17:17:33.037' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (90, 12, CAST(N'2023-07-02T17:29:12.427' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (91, 15, CAST(N'2023-07-02T17:30:33.840' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (92, NULL, CAST(N'2023-07-02T17:31:00.840' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (93, NULL, CAST(N'2023-07-02T17:33:08.060' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (94, 12, CAST(N'2023-07-02T17:33:35.463' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (95, 12, CAST(N'2023-07-02T17:37:41.487' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (96, 12, CAST(N'2023-07-02T17:38:56.317' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (97, 2024, CAST(N'2023-07-02T21:01:18.293' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (98, NULL, CAST(N'2023-07-02T21:02:48.613' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (99, 1, CAST(N'2023-07-02T21:03:45.913' AS DateTime), N'信用卡')
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (1, N'美式', 60, N'使用中深焙咖啡豆，後味帶有焦糖餅乾的甜感。', N'美式.jpeg', 1)
INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (2, N'拿鐵', 85, N'使用中深焙咖啡豆加上台灣嚴選在地小農鮮乳，後味帶有焦糖餅乾的甜感。', N'拿鐵.jpeg', 1)
INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (3, N'咖啡冰磚拿鐵', 120, N'將咖啡濃縮製成冰磚，咖啡磚融化後慢慢與鮮乳融合，喝到最後一口都是濃濃咖啡香。', N'咖啡冰磚拿鐵.jpeg', 1)
INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (4, N'摩卡', 90, N'義式濃縮加上100%法國純可可粉。', N'摩卡.jpeg', 1)
INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (5, N'焦糖瑪奇朵', 90, N'法國香草與焦糖果露搭配義式濃縮，覆上綿密奶泡後，再淋上香氣滿溢的焦糖醬。', N'焦糖瑪奇朵.jpeg', 1)
INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (6, N'蜂蜜拿鐵', 95, N'嚴選台灣在地小農生產的純蜂蜜。', N'蜂蜜拿鐵.jpeg', 1)
INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (7, N'西西里', 90, N'中烘焙咖啡豆加上鮮榨檸檬汁的完美調和，清新的檸檬香與濃醇的咖啡香意外合拍，口中酸甜交織的口感，彷彿置身在西西里島的夏日海攤。', N'西西里.jpeg', 2)
INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (8, N'咖啡檸檬氣泡飲', 80, N'使純檸檬汁和義式濃縮，混合清爽氣泡水的完美比例。', N'咖啡檸檬氣泡飲.jpeg', 2)
INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (9, N'蜂蜜檸檬氣泡飲', 70, N'台灣在地小農純蜂蜜與純檸檬汁調製而成，是目前人氣最高的。', N'蜂蜜檸檬氣泡飲.jpeg', 2)
INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (10, N'紅茶拿鐵', 60, N'阿薩姆紅茶加上義美純鮮乳。', N'紅茶拿鐵.jpeg', 3)
INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (11, N'蜂蜜紅茶', 50, N'嚴選台灣在地小農生產的純蜂蜜。', N'蜂蜜紅茶.jpeg', 3)
INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (12, N'蜂蜜紅茶拿鐵', 70, N'阿薩姆紅茶加入台灣在地小農純蜂蜜及義美純鮮奶。', N'蜂蜜紅茶拿鐵.jpeg', 3)
INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (13, N'法芙娜可可歐蕾', 100, N'100%法國純可可粉，搭配義美純鮮乳。', N'法芙娜可可歐蕾.jpeg', 3)
INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (14, N'法式焦糖可麗露', 60, N'焦糖脆皮口感，香香脆脆扎實吃！', N'法式焦糖可麗露.jpeg', 4)
INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (15, N'提拉米蘇', 80, N'進口高脂可可粉＋底層為歐洲進口小麥胚芽餅製作，是脆脆的♡ (內含微量咖啡酒)', N'提拉米蘇.jpeg', 4)
INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (16, N'經典原味手工千層', 85, N'經典原味，不甜不膩', N'經典原味手工千層.jpeg', 4)
INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (17, N'醇巧克力手工千層', 90, N'吃得到巧克力塊的千層！搭配咖啡度過舒服下午♡', N'醇巧克力手工千層.jpeg', 4)
INSERT [dbo].[products] ([P_ID], [P_Name], [Price], [P_Desc], [P_Image], [List_ID]) VALUES (18, N'伯爵茶香手工千層', 90, N'伯爵紅茶香，不甜膩的千層，剛退冰像冰淇淋口感！', N'伯爵茶香手工千層.jpeg', 4)
SET IDENTITY_INSERT [dbo].[products] OFF
GO
ALTER TABLE [dbo].[customer] ADD  CONSTRAINT [DF_customer_Point]  DEFAULT ((100)) FOR [Point]
GO
ALTER TABLE [dbo].[orderdetail]  WITH CHECK ADD  CONSTRAINT [FK_orderdetail_orders] FOREIGN KEY([O_ID])
REFERENCES [dbo].[orders] ([O_ID])
GO
ALTER TABLE [dbo].[orderdetail] CHECK CONSTRAINT [FK_orderdetail_orders]
GO
ALTER TABLE [dbo].[orderdetail]  WITH CHECK ADD  CONSTRAINT [FK_orderdetail_products] FOREIGN KEY([P_ID])
REFERENCES [dbo].[products] ([P_ID])
GO
ALTER TABLE [dbo].[orderdetail] CHECK CONSTRAINT [FK_orderdetail_products]
GO
ALTER TABLE [dbo].[orders]  WITH NOCHECK ADD  CONSTRAINT [FK_orders_customer] FOREIGN KEY([C_ID])
REFERENCES [dbo].[customer] ([C_ID])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_customer]
GO
ALTER TABLE [dbo].[products]  WITH NOCHECK ADD  CONSTRAINT [FK_products_menulist] FOREIGN KEY([List_ID])
REFERENCES [dbo].[menulist] ([List_ID])
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_menulist]
GO
