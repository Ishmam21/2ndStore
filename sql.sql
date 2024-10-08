USE [IndProj]
GO
/****** Object:  Table [dbo].[ProductINFO]    Script Date: 9/11/2024 10:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductINFO](
	[ProductID] [int] NOT NULL,
	[Brand] [nvarchar](50) NULL,
	[Model] [nvarchar](max) NULL,
	[StorageGB] [nvarchar](50) NULL,
	[Colour] [nvarchar](50) NULL,
	[Date] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_PorductINFO] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
