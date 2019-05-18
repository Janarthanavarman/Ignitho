
CREATE TABLE [dbo].[productModel](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[productcode] [varchar](10) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[type] [varchar](10) NOT NULL,
	[description] [varchar](500) NOT NULL,
	[price] [decimal](18, 0) NOT NULL,
	[quantity] [int] NOT NULL,
	[status] [char](1) NOT NULL,
	[createon] [datetime] NOT NULL,
	[createby] [int] NULL,
	[offerrefid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[productModel]  WITH CHECK ADD FOREIGN KEY([offerrefid])
REFERENCES [dbo].[offerModel] ([id])
GO

ALTER TABLE [dbo].[productModel] ADD  DEFAULT ('A') FOR [status]
GO

ALTER TABLE [dbo].[productModel] ADD  DEFAULT (getdate()) FOR [createon]
GO


