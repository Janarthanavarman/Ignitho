CREATE TABLE [dbo].[purchaseModel](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customerrefid] [int] NULL,
	[productrefid] [int] NULL,
	[offercode] [varchar](10) NULL,
	[percentage] [decimal](18, 0) NULL,
	[quantity] [int] NULL,
	[actualprice] [decimal](18, 0) NULL,
	[netprice] [decimal](18, 0) NULL,
	[status] [char](1) NOT NULL,
	[createon] [datetime] NOT NULL,
	[createby] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[purchaseModel]  WITH CHECK ADD FOREIGN KEY([customerrefid])
REFERENCES [dbo].[customerModel] ([id])
GO

ALTER TABLE [dbo].[purchaseModel]  WITH CHECK ADD FOREIGN KEY([productrefid])
REFERENCES [dbo].[productModel] ([id])
GO

ALTER TABLE [dbo].[purchaseModel] ADD  DEFAULT ('A') FOR [status]
GO

ALTER TABLE [dbo].[purchaseModel] ADD  DEFAULT (getdate()) FOR [createon]
GO


