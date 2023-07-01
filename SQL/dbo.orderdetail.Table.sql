USE [IspanPersonalProject_POS]
GO
/****** Object:  Table [dbo].[orderdetail]    Script Date: 2023/7/2 上午 02:14:06 ******/
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
SET IDENTITY_INSERT [dbo].[orderdetail] ON 

INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (1, 17, 1, 90, N'0%', N'0%', 0, 138)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (1, 8, 5, 400, N'100%', N'100%', 0, 139)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (1, 1, 2, 160, N'0%', N'0%', 1, 140)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (2, 17, 5, 450, N'0%', N'0%', 0, 142)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (2, 14, 1, 60, N'0%', N'0%', 0, 143)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (3, 14, 1, 60, N'0%', N'0%', 0, 144)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (3, 1, 1, 80, N'80%', N'80%', 1, 145)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (5, 16, 1, 85, N'0%', N'0%', 0, 146)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (6, 17, 1, 90, N'0%', N'0%', 0, 154)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (7, 16, 1, 85, N'0%', N'0%', 0, 155)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (8, 15, 1, 80, N'0%', N'0%', 0, 156)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (9, 16, 1, 85, N'0%', N'0%', 0, 157)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (10, 17, 1, 90, N'0%', N'0%', 0, 158)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (11, 17, 1, 90, N'0%', N'0%', 0, 159)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (12, 11, 1, 50, N'0%', N'0%', 0, 160)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (13, 1, 1, 60, N'100%', N'100%', 0, 161)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (14, 16, 1, 85, N'0%', N'0%', 0, 162)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (15, 17, 1, 90, N'0%', N'0%', 0, 163)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (16, 16, 1, 85, N'0%', N'0%', 0, 164)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (17, 17, 1, 90, N'0%', N'0%', 0, 165)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (18, 16, 1, 85, N'0%', N'0%', 0, 166)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (19, 17, 1, 90, N'0%', N'0%', 0, 167)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (20, 17, 1, 90, N'0%', N'0%', 0, 168)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (21, 17, 1, 90, N'0%', N'0%', 0, 169)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (22, 17, 1, 90, N'0%', N'0%', 0, 170)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (23, 16, 1, 85, N'0%', N'0%', 0, 171)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (24, 16, 1, 85, N'0%', N'0%', 0, 172)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (25, 13, 1, 100, N'40%', N'40%', 0, 173)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (26, 16, 1, 85, N'0%', N'0%', 0, 174)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (28, 17, 1, 90, N'0%', N'0%', 0, 176)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (29, 17, 1, 90, N'0%', N'0%', 0, 177)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (30, 12, 1, 70, N'0%', N'0%', 0, 180)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (31, 17, 1, 90, N'0%', N'0%', 0, 181)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (32, 16, 1, 85, N'0%', N'0%', 0, 182)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (33, 17, 1, 90, N'0%', N'0%', 0, 184)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (34, 15, 1, 80, N'0%', N'0%', 0, 185)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (34, 1, 1, 80, N'100%', N'100%', 1, 186)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (35, 4, 1, 110, N'80%', N'80%', 1, 187)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (35, 17, 1, 90, N'0%', N'0%', 0, 188)
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
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (57, 17, 1, 90, N'0%', N'0%', 0, 1151)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (58, 15, 1, 80, N'0%', N'0%', 0, 1152)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (59, 17, 1, 90, N'0%', N'0%', 0, 1153)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (60, 17, 1, 90, N'0%', N'0%', 0, 1154)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (61, 3, 1, 120, N'80%', N'80%', 0, 1155)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (62, 16, 1, 85, N'0%', N'0%', 0, 1156)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (63, 12, 1, 70, N'0%', N'0%', 0, 1157)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (64, 16, 1, 85, N'0%', N'0%', 0, 1158)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (65, 1, 1, 60, N'0%', N'0%', 0, 1159)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (66, 17, 1, 90, N'0%', N'0%', 0, 1160)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (67, 16, 1, 85, N'0%', N'0%', 0, 1161)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (68, 14, 1, 60, N'0%', N'0%', 0, 1162)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (68, 1, 1, 80, N'0%', N'0%', 1, 1163)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (68, 10, 1, 60, N'0%', N'0%', 0, 1164)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (69, 17, 1, 90, N'0%', N'0%', 0, 2164)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (70, 14, 1, 60, N'0%', N'0%', 0, 2167)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (73, 11, 5, 250, N'80%', N'80%', 0, 2168)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (74, 15, 5, 400, N'0%', N'0%', 0, 2169)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (75, 15, 5, 400, N'0%', N'0%', 0, 2170)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (76, 4, 6, 660, N'80%', N'80%', 1, 2171)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (77, 17, 5, 450, N'0%', N'0%', 0, 2177)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (78, 15, 4, 320, N'0%', N'0%', 0, 2178)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (79, 16, 1, 85, N'0%', N'0%', 0, 2179)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (80, 17, 1, 90, N'0%', N'0%', 0, 2180)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (81, 4, 1, 90, N'0%', N'0%', 0, 2182)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (82, 4, 1, 90, N'0%', N'0%', 0, 2190)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (83, 4, 1, 90, N'80%', N'80%', 0, 2191)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (84, 3, 1, 120, N'0%', N'0%', 0, 2192)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (85, 17, 1, 90, N'0%', N'0%', 0, 2193)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (86, 11, 1, 50, N'100%', N'100%', 0, 2194)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (87, 4, 1, 90, N'100%', N'100%', 0, 2195)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (88, 1, 1, 60, N'0%', N'80%', 0, 2196)
INSERT [dbo].[orderdetail] ([O_ID], [P_ID], [Quantity], [Subtotal], [Sugar], [Ice], [Espresso], [OrderDetail_ID]) VALUES (88, 15, 1, 80, N'0%', N'0%', 0, 2197)
SET IDENTITY_INSERT [dbo].[orderdetail] OFF
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
