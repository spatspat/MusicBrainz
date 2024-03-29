USE [MusicBrainzDB]
GO
ALTER TABLE [dbo].[Aliases] DROP CONSTRAINT [FK_Aliases_Artists_ArtistId]
GO
/****** Object:  Table [dbo].[Artists]    Script Date: 6/15/2019 9:42:31 PM ******/
DROP TABLE [dbo].[Artists]
GO
/****** Object:  Table [dbo].[Aliases]    Script Date: 6/15/2019 9:42:31 PM ******/
DROP TABLE [dbo].[Aliases]
GO
/****** Object:  Table [dbo].[Aliases]    Script Date: 6/15/2019 9:42:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aliases](
	[AliaseId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[ArtistId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Aliases] PRIMARY KEY CLUSTERED 
(
	[AliaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Artists]    Script Date: 6/15/2019 9:42:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artists](
	[ArtistId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
 CONSTRAINT [PK_Artists] PRIMARY KEY CLUSTERED 
(
	[ArtistId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Aliases] ON 

INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (3, N'Metalica', N'65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (4, N'메탈리카', N'65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (5, N'Mott The Hoppie', N'435f1441-0f43-479d-92db-a506449a686b')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (6, N'Mott The Hopple', N'435f1441-0f43-479d-92db-a506449a686b')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (7, N'Megadeath', N'a9044915-8be3-4c7e-b11f-9e2d2ea0a91e')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (8, N'John Coltraine', N'b625448e-bf4a-41c3-a421-72ad46cdb831')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (9, N'John William Coltrane', N'b625448e-bf4a-41c3-a421-72ad46cdb831')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (10, N'Mogwa', N'd700b3f5-45af-4d02-95ed-57d301bda93e')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (11, N'Johhny Cash', N'18fa2fd5-3ef2-4496-ba9f-6dae655b2a4f')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (12, N'Jonny Cash', N'18fa2fd5-3ef2-4496-ba9f-6dae655b2a4f')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (13, N'Jack Hody Johnson', N'6456a893-c1e9-4e3d-86f7-0008b0a3ac8a')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (14, N'John Anthony Frusciante', N'f1571db1-c672-4a54-a2cf-aaa329f26f0b')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (15, N'E. John', N'b83bc61f-8451-4a5d-8b8e-7e9ed295e822')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (16, N'Elthon John', N'b83bc61f-8451-4a5d-8b8e-7e9ed295e822')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (17, N'Elton Jphn', N'b83bc61f-8451-4a5d-8b8e-7e9ed295e822')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (18, N'John Elton', N'b83bc61f-8451-4a5d-8b8e-7e9ed295e822')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (19, N'Reginald Kenneth Dwight', N'b83bc61f-8451-4a5d-8b8e-7e9ed295e822')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (20, N'ランシド', N'24f8d8a5-269b-475c-a1cb-792990b0b2ee')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (21, N'The Transplants', N'29f3e1bf-aec1-4d0a-9ef3-0cb95e8a3699')
INSERT [dbo].[Aliases] ([AliaseId], [Name], [ArtistId]) VALUES (22, N'Op Ivy', N'931e1d1f-6b2f-4ff8-9f70-aa537210cd46')
SET IDENTITY_INSERT [dbo].[Aliases] OFF
INSERT [dbo].[Artists] ([ArtistId], [Name], [Country]) VALUES (N'6456a893-c1e9-4e3d-86f7-0008b0a3ac8a', N'Jack Johnson', N'US')
INSERT [dbo].[Artists] ([ArtistId], [Name], [Country]) VALUES (N'144ef525-85e9-40c3-8335-02c32d0861f3', N'John Mayer', N'US')
INSERT [dbo].[Artists] ([ArtistId], [Name], [Country]) VALUES (N'29f3e1bf-aec1-4d0a-9ef3-0cb95e8a3699', N'Transplants', N'US')
INSERT [dbo].[Artists] ([ArtistId], [Name], [Country]) VALUES (N'd700b3f5-45af-4d02-95ed-57d301bda93e', N'Mogwai', N'GB')
INSERT [dbo].[Artists] ([ArtistId], [Name], [Country]) VALUES (N'650e7db6-b795-4eb5-a702-5ea2fc46c848', N'Lady Gaga', N'US')
INSERT [dbo].[Artists] ([ArtistId], [Name], [Country]) VALUES (N'18fa2fd5-3ef2-4496-ba9f-6dae655b2a4f', N'Johnny Cash', N'US')
INSERT [dbo].[Artists] ([ArtistId], [Name], [Country]) VALUES (N'b625448e-bf4a-41c3-a421-72ad46cdb831', N'John Coltrane', N'US')
INSERT [dbo].[Artists] ([ArtistId], [Name], [Country]) VALUES (N'24f8d8a5-269b-475c-a1cb-792990b0b2ee', N'Rancid', N'US')
INSERT [dbo].[Artists] ([ArtistId], [Name], [Country]) VALUES (N'b83bc61f-8451-4a5d-8b8e-7e9ed295e822', N'Elton John', N'GB')
INSERT [dbo].[Artists] ([ArtistId], [Name], [Country]) VALUES (N'65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab', N'Metallica', N'US')
INSERT [dbo].[Artists] ([ArtistId], [Name], [Country]) VALUES (N'a9044915-8be3-4c7e-b11f-9e2d2ea0a91e', N'Megadeth', N'US')
INSERT [dbo].[Artists] ([ArtistId], [Name], [Country]) VALUES (N'435f1441-0f43-479d-92db-a506449a686b', N'Mott the Hoople', N'GB')
INSERT [dbo].[Artists] ([ArtistId], [Name], [Country]) VALUES (N'931e1d1f-6b2f-4ff8-9f70-aa537210cd46', N'Operation Ivy', N'US')
INSERT [dbo].[Artists] ([ArtistId], [Name], [Country]) VALUES (N'f1571db1-c672-4a54-a2cf-aaa329f26f0b', N'John Frusciante', N'US')
INSERT [dbo].[Artists] ([ArtistId], [Name], [Country]) VALUES (N'c44e9c22-ef82-4a77-9bcd-af6c958446d6', N'Mumford & Sons', N'GB')
ALTER TABLE [dbo].[Aliases]  WITH CHECK ADD  CONSTRAINT [FK_Aliases_Artists_ArtistId] FOREIGN KEY([ArtistId])
REFERENCES [dbo].[Artists] ([ArtistId])
GO
ALTER TABLE [dbo].[Aliases] CHECK CONSTRAINT [FK_Aliases_Artists_ArtistId]
GO
