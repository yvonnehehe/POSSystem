USE [IspanPersonalProject_POS]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 2023/7/2 上午 02:14:06 ******/
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
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (1, 1, CAST(N'2023-06-29T20:46:33.373' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (2, 19, CAST(N'2023-06-29T20:49:10.927' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (3, 19, CAST(N'2023-06-29T21:23:52.453' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (4, 2, CAST(N'2023-06-29T21:24:09.960' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (5, 3, CAST(N'2023-06-29T21:37:53.810' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (6, 4, CAST(N'2023-06-29T22:10:58.857' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (7, 2, CAST(N'2023-06-29T22:18:23.910' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (8, NULL, CAST(N'2023-06-29T22:24:28.270' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (9, 6, CAST(N'2023-06-29T23:11:30.713' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (10, 7, CAST(N'2023-06-29T23:14:12.960' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (11, 8, CAST(N'2023-06-29T23:18:07.373' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (12, 9, CAST(N'2023-06-29T23:19:20.797' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (13, 10, CAST(N'2023-06-29T23:23:14.320' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (14, 10, CAST(N'2023-06-29T23:23:57.750' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (15, 11, CAST(N'2023-06-29T23:26:15.523' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (16, 11, CAST(N'2023-06-29T23:27:08.850' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (17, 12, CAST(N'2023-06-29T23:31:09.193' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (18, 12, CAST(N'2023-06-29T23:37:34.703' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (19, 12, CAST(N'2023-06-29T23:38:10.407' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (20, 12, CAST(N'2023-06-29T23:44:23.733' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (21, 13, CAST(N'2023-06-29T23:53:30.057' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (22, 13, CAST(N'2023-06-29T23:56:17.830' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (23, 2, CAST(N'2023-06-29T23:57:24.567' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (24, 3, CAST(N'2023-06-29T23:59:48.263' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (25, 21, CAST(N'2023-06-30T00:01:10.793' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (26, 19, CAST(N'2023-06-30T00:03:05.050' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (27, 20, CAST(N'2023-06-30T00:05:46.177' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (28, 19, CAST(N'2023-06-30T00:08:53.667' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (29, 19, CAST(N'2023-06-30T00:10:36.883' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (30, 15, CAST(N'2023-06-30T00:16:42.167' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (31, 19, CAST(N'2023-06-30T17:08:01.027' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (32, 19, CAST(N'2023-06-30T17:09:11.123' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (33, 19, CAST(N'2023-06-30T17:11:36.467' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (34, NULL, CAST(N'2023-06-30T18:14:01.683' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (35, 19, CAST(N'2023-06-30T18:15:00.063' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (36, 19, CAST(N'2023-06-30T18:19:36.247' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (37, 19, CAST(N'2023-06-30T18:46:40.507' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (38, 19, CAST(N'2023-06-30T18:47:04.613' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (39, NULL, CAST(N'2023-07-01T15:29:54.387' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (40, NULL, CAST(N'2023-07-01T15:32:26.713' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (41, 10, CAST(N'2023-07-01T15:32:35.747' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (42, 11, CAST(N'2023-07-01T15:39:18.027' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (43, NULL, CAST(N'2023-07-01T15:39:55.810' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (44, NULL, CAST(N'2023-07-01T15:43:32.920' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (45, 13, CAST(N'2023-07-01T15:44:52.710' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (46, 15, CAST(N'2023-07-01T15:46:16.163' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (47, 14, CAST(N'2023-07-01T15:47:09.773' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (48, 13, CAST(N'2023-07-01T15:47:58.567' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (49, 5, CAST(N'2023-07-01T15:48:58.640' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (50, 6, CAST(N'2023-07-01T15:49:43.933' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (51, 7, CAST(N'2023-07-01T15:50:48.337' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (52, 10, CAST(N'2023-07-01T15:52:40.310' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (53, 12, CAST(N'2023-07-01T15:54:50.997' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (54, 14, CAST(N'2023-07-01T15:56:57.220' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (55, 16, CAST(N'2023-07-01T15:58:48.380' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (56, 19, CAST(N'2023-07-01T16:00:53.513' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (57, 20, CAST(N'2023-07-01T16:07:49.860' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (58, 21, CAST(N'2023-07-01T16:08:08.653' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (59, 21, CAST(N'2023-07-01T16:08:56.650' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (60, 20, CAST(N'2023-07-01T16:10:20.037' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (61, 19, CAST(N'2023-07-01T16:10:39.393' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (62, 16, CAST(N'2023-07-01T16:11:03.643' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (63, 15, CAST(N'2023-07-01T16:22:22.873' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (64, NULL, CAST(N'2023-07-01T16:27:35.907' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (65, NULL, CAST(N'2023-07-01T16:28:15.987' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (66, NULL, CAST(N'2023-07-01T16:29:41.210' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (67, NULL, CAST(N'2023-07-01T16:30:47.610' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (68, 19, CAST(N'2023-07-01T18:20:52.387' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (69, 20, CAST(N'2023-07-01T20:30:44.970' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (70, 1, CAST(N'2023-07-01T20:49:20.323' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (71, 1, CAST(N'2023-07-01T20:49:39.647' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (72, 1, CAST(N'2023-07-01T20:49:52.447' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (73, 1, CAST(N'2023-07-01T20:52:40.157' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (74, 1, CAST(N'2023-07-01T20:53:13.743' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (75, 1, CAST(N'2023-07-01T20:56:51.897' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (76, 1, CAST(N'2023-07-01T20:58:08.340' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (77, 1, CAST(N'2023-07-01T21:09:31.450' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (78, 1, CAST(N'2023-07-01T21:12:22.827' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (79, NULL, CAST(N'2023-07-01T21:20:52.307' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (80, NULL, CAST(N'2023-07-01T21:27:20.057' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (81, NULL, CAST(N'2023-07-01T21:29:52.860' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (82, NULL, CAST(N'2023-07-02T00:30:09.277' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (83, NULL, CAST(N'2023-07-02T00:43:06.787' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (84, NULL, CAST(N'2023-07-02T00:45:48.010' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (85, NULL, CAST(N'2023-07-02T00:50:57.347' AS DateTime), N'現金')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (86, NULL, CAST(N'2023-07-02T00:56:01.627' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (87, NULL, CAST(N'2023-07-02T00:57:28.937' AS DateTime), N'信用卡')
INSERT [dbo].[orders] ([O_ID], [C_ID], [OrderDate], [PaymentMethod]) VALUES (88, 1, CAST(N'2023-07-02T01:00:44.860' AS DateTime), N'信用卡')
GO
ALTER TABLE [dbo].[orders]  WITH NOCHECK ADD  CONSTRAINT [FK_orders_customer] FOREIGN KEY([C_ID])
REFERENCES [dbo].[customer] ([C_ID])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_customer]
GO
