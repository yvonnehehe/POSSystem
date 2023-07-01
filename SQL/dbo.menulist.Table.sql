USE [IspanPersonalProject_POS]
GO
/****** Object:  Table [dbo].[menulist]    Script Date: 2023/7/2 上午 02:14:06 ******/
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
SET IDENTITY_INSERT [dbo].[menulist] ON 

INSERT [dbo].[menulist] ([List_ID], [Seq], [ChName], [EngName]) VALUES (1, 1, N'咖啡', N'coffee')
INSERT [dbo].[menulist] ([List_ID], [Seq], [ChName], [EngName]) VALUES (2, 2, N'氣泡飲料', N'Fizz')
INSERT [dbo].[menulist] ([List_ID], [Seq], [ChName], [EngName]) VALUES (3, 3, N'鮮奶茶', N'Tea and Flavor Milk')
INSERT [dbo].[menulist] ([List_ID], [Seq], [ChName], [EngName]) VALUES (4, 4, N'甜點', N'Dessert')
SET IDENTITY_INSERT [dbo].[menulist] OFF
GO
