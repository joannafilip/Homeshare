CREATE TABLE [dbo].[BienEchange](
	[idBien] [int] IDENTITY(1,1) NOT NULL,
	[titre] [nvarchar](50) NOT NULL,
	[DescCourte] [nvarchar](150) NOT NULL,
	[DescLong] [ntext] NOT NULL,
	[NombrePerson] [int] NOT NULL,
	[Pays] [int] NOT NULL,
	[Ville] [nvarchar](50) NOT NULL,
	[Rue] [nvarchar](50) NOT NULL,
	[Numero] [nvarchar](5) NOT NULL,
	[CodePostal] [nvarchar](50) NOT NULL,
	[Photo] [nvarchar](50) NOT NULL,
	[AssuranceObligatoire] [bit] NOT NULL,
	[isEnabled] [bit] NOT NULL,
	[DisabledDate] [date] NULL,
	[Latitude] [nvarchar](50) NOT NULL,
	[Longitude] [nvarchar](50) NOT NULL,
	[idMembre] [int] NOT NULL,
	[DateCreation] [date] NOT NULL,
 CONSTRAINT [PK_BienEchange] PRIMARY KEY CLUSTERED 
(
	[idBien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_BienEchange_membre]    Script Date: 03/09/2015 15:20:04 ******/
ALTER TABLE [dbo].[BienEchange]  WITH CHECK ADD  CONSTRAINT [FK_BienEchange_membre] FOREIGN KEY([idMembre])
REFERENCES [dbo].[Membre] ([idMembre])
GO

ALTER TABLE [dbo].[BienEchange] CHECK CONSTRAINT [FK_BienEchange_membre]
GO
/****** Object:  ForeignKey [FK_BienEchange_Pays]    Script Date: 03/09/2015 15:20:04 ******/
ALTER TABLE [dbo].[BienEchange]  WITH CHECK ADD  CONSTRAINT [FK_BienEchange_Pays] FOREIGN KEY([Pays])
REFERENCES [dbo].[Pays] ([idPays])
GO

ALTER TABLE [dbo].[BienEchange] CHECK CONSTRAINT [FK_BienEchange_Pays]
GO
/****** Object:  Default [DF_BienEchange_Pays]    Script Date: 03/09/2015 15:20:04 ******/
ALTER TABLE [dbo].[BienEchange] ADD  CONSTRAINT [DF_BienEchange_Pays]  DEFAULT ((1)) FOR [Pays]
GO
/****** Object:  Default [DF_BienEchange_AssuranceObligatoire]    Script Date: 03/09/2015 15:20:04 ******/
ALTER TABLE [dbo].[BienEchange] ADD  CONSTRAINT [DF_BienEchange_AssuranceObligatoire]  DEFAULT ((0)) FOR [AssuranceObligatoire]
GO
/****** Object:  Default [DF_BienEchange_isEnabled]    Script Date: 03/09/2015 15:20:04 ******/
ALTER TABLE [dbo].[BienEchange] ADD  CONSTRAINT [DF_BienEchange_isEnabled]  DEFAULT ((0)) FOR [isEnabled]
GO
/****** Object:  Default [DF_BienEchange_DateCreation]    Script Date: 03/09/2015 15:20:04 ******/
ALTER TABLE [dbo].[BienEchange] ADD  CONSTRAINT [DF_BienEchange_DateCreation]  DEFAULT (getdate()) FOR [DateCreation]