
CREATE TABLE [dbo].[customerModel](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[custid] [varchar](10) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[phone] [varchar](10) NOT NULL,
	[gender] [varchar](6) NOT NULL,
	[address] [varchar](500) NOT NULL,
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

ALTER TABLE [dbo].[customerModel] ADD  DEFAULT ('A') FOR [status]
GO

ALTER TABLE [dbo].[customerModel] ADD  DEFAULT (getdate()) FOR [createon]
GO


