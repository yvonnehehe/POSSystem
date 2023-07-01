USE [IspanPersonalProject_POS]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 2023/7/2 上午 02:14:06 ******/
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
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (1, N'宥勝', N'0912-345-679', N'台中市清水區', N'amber6541@gmail.com', CAST(N'1982-06-09' AS Date), 8900, N'aaa1', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (2, N'NONO', N'07-333-6789', N'台北市大安區', N'longoria633@gmail.com', CAST(N'1971-03-21' AS Date), 500, N'aaa2', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (3, N'徐熙娣', N'0977-555-999', N'高雄市鼓山區', N'rogers9086@gmail.com', CAST(N'1978-06-14' AS Date), 2000, N'aaa3', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (4, N'炎亞綸', N'0988-111-666', N'台南市仁德區', N'leilani8173@outlook.com', CAST(N'1985-11-20' AS Date), 1500, N'aaa4', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (5, N'汪小菲', N'0955-555-555', N'桃園市龜山區', N'haye2560@yahoo.com', CAST(N'1981-06-27' AS Date), 5000, N'aaa5', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (6, N'許傑輝', N'0911-222-555', N'台北市信義區', N'hill4328@gmail.com', CAST(N'1966-01-12' AS Date), 1, N'aaa6', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (7, N'夏宇童', N'0922-456-666', N'新北市板橋區', N'oscar8938@gmail.com', CAST(N'1988-08-19' AS Date), 900, N'aaa7', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (8, N'黃子佼', N'0915-654-888', N'台中市北區', N'grant4519@outlook.com', CAST(N'1972-03-30' AS Date), 1200, N'aaa8', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (9, N'陳建州', N'0956-456-214', N'台中市烏日區', N'evelyn6627@gmail.com', CAST(N'1977-05-02' AS Date), 500, N'aaa9', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (10, N'吳宗憲', N'0911-235-888', N'台南市安定區', N'gloria7002@yahoo.com', CAST(N'1962-09-26' AS Date), 800, N'aaa10', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (11, N'周杰倫', N'0944-655-233', N'新竹縣竹北市', N'garland8077@hotmail.com', CAST(N'1995-01-01' AS Date), 900, N'aaa11', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (12, N'蔡依林', N'0955-123-896', N'新北市板橋區', N'sterling5804@icloud.com', CAST(N'1992-05-03' AS Date), 1000, N'aaa12', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (13, N'林志玲', N'0945-268-522', N'花蓮縣瑞穗區', N'orrico4056@hotmail.com', CAST(N'1993-08-08' AS Date), 1200, N'aaa13', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (14, N'楊丞琳', N'0942-695-222', N'台中市西區', N'chet7247@gmail.com', CAST(N'1985-02-04' AS Date), 1300, N'aaa14', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (15, N'李榮浩', N'0945-555-604', N'台中市西區', N'kim9474@outlook.com', CAST(N'1955-01-31' AS Date), 1000, N'aaa15', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (16, N'范瑋琪', N'0933-444-555', N'台北市大安區', N'trevor3021@yahoo.com', CAST(N'1979-03-18' AS Date), 2000, N'aaa16', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (19, N'楊丞琳', N'09350203', N'新竹', N'jocelyn2734@gmail.com', CAST(N'1984-06-04' AS Date), 5200, N'aaa19', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (20, N'yvonne', N'0955-350-203', N'新竹縣', N'percy4076@gmail.com', CAST(N'1999-01-01' AS Date), 2000, N'zxc123', N'a123')
INSERT [dbo].[customer] ([C_ID], [C_Name], [Phone], [Address], [Email], [Birth], [Point], [Account], [Password]) VALUES (21, N'美珠', N'09955555', N'新竹', N'vanessa1394@icloud.com', CAST(N'1999-07-07' AS Date), 13, N'aaa21', N'a123')
SET IDENTITY_INSERT [dbo].[customer] OFF
GO
