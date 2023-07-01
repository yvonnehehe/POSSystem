USE [IspanPersonalProject_POS]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2023/7/2 上午 02:14:06 ******/
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
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([E_ID], [E_Name], [E_Account], [E_Password]) VALUES (1, N'店長', N'0000', N'0000')
INSERT [dbo].[Employees] ([E_ID], [E_Name], [E_Account], [E_Password]) VALUES (2, N'員工1號', N'1111', N'1111')
INSERT [dbo].[Employees] ([E_ID], [E_Name], [E_Account], [E_Password]) VALUES (3, N'員工2號', N'2222', N'2222')
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
