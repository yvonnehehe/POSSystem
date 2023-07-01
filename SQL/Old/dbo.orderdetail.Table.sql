USE [IspanPersonalProject_POS]
GO
/****** Object:  Table [dbo].[orderdetail]    Script Date: 2023/6/23 上午 02:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderdetail](
	[o_id] [int] NOT NULL,
	[p_id] [int] NOT NULL,
	[p_name] [nvarchar](100) NULL,
	[quantity] [int] NULL,
	[totalprice] [int] NULL,
	[sugar] [nvarchar](50) NULL,
	[ice] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[o_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
