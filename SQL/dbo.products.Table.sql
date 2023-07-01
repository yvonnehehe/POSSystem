USE [IspanPersonalProject_POS]
GO
/****** Object:  Table [dbo].[products]    Script Date: 2023/7/2 上午 02:14:06 ******/
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
ALTER TABLE [dbo].[products]  WITH NOCHECK ADD  CONSTRAINT [FK_products_menulist] FOREIGN KEY([List_ID])
REFERENCES [dbo].[menulist] ([List_ID])
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_menulist]
GO
