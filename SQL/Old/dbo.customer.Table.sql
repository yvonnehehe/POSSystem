USE [IspanPersonalProject_POS]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 2023/6/23 上午 02:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[c_id] [int] IDENTITY(1,1) NOT NULL,
	[c_name] [nvarchar](50) NULL,
	[phone] [nvarchar](50) NULL,
	[address] [nvarchar](100) NULL,
	[email] [nvarchar](50) NULL,
	[birth] [date] NULL,
	[point] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[c_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (1, N'陳大喵', N'0912-345-678', N'高雄市前金區', N'mm@hh.com.tw', CAST(N'1985-05-09' AS Date), 10000)
INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (2, N'黃小貓', N'07-333-6789', N'高雄市三民區', N'pp@nn.com.tw', CAST(N'1988-06-03' AS Date), 500)
INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (3, N'張大書', N'0977-555-999', N'高雄市鼓山區', N'zz@dd.com.tw', CAST(N'1978-11-09' AS Date), 2000)
INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (4, N'黃中春', N'0988-111-666', N'台南市仁德區', N'rr@tt.com.tw', CAST(N'1979-01-05' AS Date), 1500)
INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (5, N'王小春', N'0955-555-555', N'桃園市龜山區', N'show@com.tw', CAST(N'1955-12-12' AS Date), 5000)
INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (6, N'陳小美', N'0911-222-555', N'台北市信義區', N'ee@gg.com.tw', CAST(N'1990-01-01' AS Date), 300)
INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (7, N'林大鵬', N'0922-456-666', N'新北市板橋區', N'oo@ee.com.tw', CAST(N'1985-05-15' AS Date), 900)
INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (8, N'王小華', N'0915-654-888', N'台中市北區', N'pp@rr.com.tw', CAST(N'1998-12-10' AS Date), 1200)
INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (9, N'陳阿黃', N'0956-456-214', N'台中市烏日區', N'ww@rr.com.tw', CAST(N'1995-11-23' AS Date), 500)
INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (10, N'吳宗憲', N'0911-235-888', N'桃園市蘆竹區', N'nn@rr.com.tw', CAST(N'1998-03-16' AS Date), 800)
INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (11, N'周杰倫', N'0944-655-233', N'新竹縣竹北市', N'cc@rr.com.tw', CAST(N'1995-01-01' AS Date), 900)
INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (12, N'蔡依林', N'0955-123-896', N'新北市板橋區', N'xx@rr.com.tw', CAST(N'1992-05-03' AS Date), 1000)
INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (13, N'林志玲', N'0945-268-522', N'花蓮縣瑞穗區', N'zz@rr.com.tw', CAST(N'1993-08-08' AS Date), 1200)
INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (14, N'楊丞琳', N'0942-695-222', N'台中市西區', N'll@re.com.tw', CAST(N'1985-02-04' AS Date), 1300)
INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (15, N'李榮浩', N'0945-555-604', N'台中市西區', N'umzz@rr.com.tw', CAST(N'1955-01-31' AS Date), 1000)
INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (16, N'郭采潔', N'0933-444-555', N'台北市大安區', N'aa@re.com.tw', CAST(N'1990-12-31' AS Date), 2000)
INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (17, N'李知恩', N'0932-654-987', N'台南市善化區', N'bb@re.com.tw', CAST(N'1996-10-22' AS Date), 1500)
INSERT [dbo].[customer] ([c_id], [c_name], [phone], [address], [email], [birth], [point]) VALUES (18, N'葉舒華', N'0944-563-111', N'台中市潭子區', N'mm@.rr.com.tw', CAST(N'1997-11-20' AS Date), 1800)
SET IDENTITY_INSERT [dbo].[customer] OFF
GO
