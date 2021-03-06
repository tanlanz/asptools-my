USE [mytools]
GO
/****** Object:  Table [dbo].[IPdeny]    Script Date: 2016/8/5 13:29:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IPdeny](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ip] [varchar](50) NULL,
	[state] [int] NULL,
 CONSTRAINT [PK__IPdeny__3213E83FF5D527F5] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[md5]    Script Date: 2016/8/5 13:29:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[md5](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[text1] [nvarchar](255) NOT NULL,
	[text2] [varchar](255) NOT NULL,
	[time] [datetime] NOT NULL,
	[ip] [char](50) NULL,
 CONSTRAINT [PK__md5__3213E83F46DB3CAC] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[report]    Script Date: 2016/8/5 13:29:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[report](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](20) NULL,
	[email] [varchar](50) NULL,
	[message1] [nvarchar](255) NULL,
	[send_time] [datetime] NULL,
	[ip] [varchar](32) NULL,
 CONSTRAINT [PK__report__3213E83F49BAFB95] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[show]    Script Date: 2016/8/5 13:29:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[show](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](255) NOT NULL,
	[name] [nvarchar](25) NULL,
	[text] [nvarchar](500) NOT NULL,
	[state] [int] NULL,
	[changeTime] [datetime] NULL,
	[sort] [int] NULL,
 CONSTRAINT [PK__show__3213E83FE245AF30] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 2016/8/5 13:29:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[username] [varchar](50) NOT NULL,
	[age] [int] NULL,
	[sex] [nvarchar](2) NULL,
	[phone] [int] NULL,
	[ID_Card] [varchar](25) NULL,
	[email] [varchar](25) NULL,
	[photo] [varchar](50) NULL,
 CONSTRAINT [PK__UserInfo__3213E83F75E0F9D2] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[users]    Script Date: 2016/8/5 13:29:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[name] [nvarchar](25) NOT NULL,
	[password] [varchar](100) NOT NULL,
	[signInTime] [datetime] NOT NULL,
	[state] [int] NULL,
 CONSTRAINT [PK__users__3213E83F3EBABF99] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[IPdeny] ON 

INSERT [dbo].[IPdeny] ([id], [ip], [state]) VALUES (0, N'119.124.30.43', 1)
INSERT [dbo].[IPdeny] ([id], [ip], [state]) VALUES (1, N'119.124.18.205', 1)
INSERT [dbo].[IPdeny] ([id], [ip], [state]) VALUES (2, N'119.124.31.97', 1)
INSERT [dbo].[IPdeny] ([id], [ip], [state]) VALUES (3, N'119.124.31.97', 1)
INSERT [dbo].[IPdeny] ([id], [ip], [state]) VALUES (4, N'119.124.31.97', 1)
INSERT [dbo].[IPdeny] ([id], [ip], [state]) VALUES (5, N'119.124.31.97', 1)
INSERT [dbo].[IPdeny] ([id], [ip], [state]) VALUES (6, N'119.124.31.85', 1)
INSERT [dbo].[IPdeny] ([id], [ip], [state]) VALUES (7, N'119.124.31.85', 1)
INSERT [dbo].[IPdeny] ([id], [ip], [state]) VALUES (8, N'119.124.30.128', 1)
SET IDENTITY_INSERT [dbo].[IPdeny] OFF
SET IDENTITY_INSERT [dbo].[md5] ON 

INSERT [dbo].[md5] ([id], [text1], [text2], [time], [ip]) VALUES (1, N'123', N'202CB962AC59075B964B07152D234B70', CAST(0x0000A63800E95BF1 AS DateTime), NULL)
INSERT [dbo].[md5] ([id], [text1], [text2], [time], [ip]) VALUES (6, N'123456', N'E10ADC3949BA59ABBE56E057F20F883E', CAST(0x0000A63800EC0A04 AS DateTime), NULL)
INSERT [dbo].[md5] ([id], [text1], [text2], [time], [ip]) VALUES (7, N'admin', N'21232F297A57A5A743894A0E4A801FC3', CAST(0x0000A64E00E64C2B AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[md5] OFF
SET IDENTITY_INSERT [dbo].[report] ON 

INSERT [dbo].[report] ([id], [name], [email], [message1], [send_time], [ip]) VALUES (7, N'撒地方大师傅a', N' 啊士大夫萨芬', N' 发士大夫士大夫十大发啊发送', CAST(0x0000A658016971E9 AS DateTime), N'119.124.30.128')
INSERT [dbo].[report] ([id], [name], [email], [message1], [send_time], [ip]) VALUES (8, N'啊幅度萨芬', N'打折幅度', N'阿凡达是', CAST(0x0000A658016BEE5E AS DateTime), N'119.124.30.128')
INSERT [dbo].[report] ([id], [name], [email], [message1], [send_time], [ip]) VALUES (9, N'啊幅度萨芬', N'打折幅度', N'阿凡达是', CAST(0x0000A658016BF1FF AS DateTime), N'119.124.30.128')
INSERT [dbo].[report] ([id], [name], [email], [message1], [send_time], [ip]) VALUES (10, N'啊幅度萨芬', N'打折幅度', N'阿凡达是', CAST(0x0000A658016BF450 AS DateTime), N'119.124.30.128')
SET IDENTITY_INSERT [dbo].[report] OFF
SET IDENTITY_INSERT [dbo].[show] ON 

INSERT [dbo].[show] ([id], [title], [name], [text], [state], [changeTime], [sort]) VALUES (2, N'', NULL, N'', NULL, NULL, NULL)
INSERT [dbo].[show] ([id], [title], [name], [text], [state], [changeTime], [sort]) VALUES (3, N'', NULL, N'', NULL, NULL, NULL)
INSERT [dbo].[show] ([id], [title], [name], [text], [state], [changeTime], [sort]) VALUES (4, N'', NULL, N'', NULL, NULL, NULL)
INSERT [dbo].[show] ([id], [title], [name], [text], [state], [changeTime], [sort]) VALUES (5, N'这是被删除后的恢复标题', NULL, N'这文章主题，里面包括了主要的内容，第一次的内容被误删，因此由此内容代替，此外下一篇的内容仍然会是测试。', 0, NULL, 1)
INSERT [dbo].[show] ([id], [title], [name], [text], [state], [changeTime], [sort]) VALUES (6, N'This is a Blog Title', NULL, N'This is my world!', 0, NULL, 1)
INSERT [dbo].[show] ([id], [title], [name], [text], [state], [changeTime], [sort]) VALUES (20, N'有感而发', NULL, N'“你住的城市下雨了,很想问你有没有带伞，可是我忍住了，因为我怕你说没带，而我又无能为力，就像是我爱你，却给不到你想要的陪伴。”', 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[show] OFF
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [username], [name], [password], [signInTime], [state]) VALUES (1, N'admin', N'admin', N'21232F297A57A5A743894A0E4A801FC3', CAST(0x0000A65900D79EE7 AS DateTime), 1)
INSERT [dbo].[users] ([id], [username], [name], [password], [signInTime], [state]) VALUES (2, N'zjq', N'zjq', N'21232F297A57A5A743894A0E4A801FC3', CAST(0x0000A64E00E88035 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[users] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__users__F3DBC572CD361614]    Script Date: 2016/8/5 13:29:27 ******/
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [UQ__users__F3DBC572CD361614] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[show] ADD  CONSTRAINT [DF__show__state__49C3F6B7]  DEFAULT ('0') FOR [state]
GO
ALTER TABLE [dbo].[show] ADD  CONSTRAINT [DF__show__sort__4AB81AF0]  DEFAULT ('1') FOR [sort]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF__users__state__24927208]  DEFAULT ((0)) FOR [state]
GO
ALTER TABLE [dbo].[UserInfo]  WITH CHECK ADD  CONSTRAINT [FK__UserInfo__userId__286302EC] FOREIGN KEY([userId])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[UserInfo] CHECK CONSTRAINT [FK__UserInfo__userId__286302EC]
GO
ALTER TABLE [dbo].[UserInfo]  WITH CHECK ADD  CONSTRAINT [FK__UserInfo__userna__276EDEB3] FOREIGN KEY([username])
REFERENCES [dbo].[users] ([username])
GO
ALTER TABLE [dbo].[UserInfo] CHECK CONSTRAINT [FK__UserInfo__userna__276EDEB3]
GO
