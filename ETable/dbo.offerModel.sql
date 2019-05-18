CREATE TABLE [dbo].[offerModel](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[offercode] [varchar](10) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](500) NOT NULL,
	[percentage] [decimal](18, 0) NOT NULL,
	[status] [char](1) NOT NULL,
	[createon] [datetime]NOT NULL,
	[createby] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[offerModel] ADD  DEFAULT ('A') FOR [status]
GO

ALTER TABLE [dbo].[offerModel] ADD  DEFAULT (getdate()) FOR [createon]
GO


