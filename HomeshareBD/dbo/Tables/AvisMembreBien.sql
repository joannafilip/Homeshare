CREATE TABLE [dbo].[AvisMembreBien](
	[idAvis] [int] IDENTITY(1,1) NOT NULL,
	[note] [int] NOT NULL,
	[message] [ntext] NOT NULL,
	[idMembre] [int] NOT NULL,
	[idBien] [int] NOT NULL,
	[DateAvis] [datetime] NOT NULL,
	[Approuve] [bit] NOT NULL,
 CONSTRAINT [PK_AvisMembreBien] PRIMARY KEY CLUSTERED 
(
	[idAvis] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_AvisMembreBien_BienEchange]    Script Date: 03/09/2015 15:20:04 ******/
ALTER TABLE [dbo].[AvisMembreBien]  WITH CHECK ADD  CONSTRAINT [FK_AvisMembreBien_BienEchange] FOREIGN KEY([idBien])
REFERENCES [dbo].[BienEchange] ([idBien])
GO

ALTER TABLE [dbo].[AvisMembreBien] CHECK CONSTRAINT [FK_AvisMembreBien_BienEchange]
GO
/****** Object:  ForeignKey [FK_AvisMembreBien_membre]    Script Date: 03/09/2015 15:20:04 ******/
ALTER TABLE [dbo].[AvisMembreBien]  WITH CHECK ADD  CONSTRAINT [FK_AvisMembreBien_membre] FOREIGN KEY([idMembre])
REFERENCES [dbo].[Membre] ([idMembre])
GO

ALTER TABLE [dbo].[AvisMembreBien] CHECK CONSTRAINT [FK_AvisMembreBien_membre]
GO
/****** Object:  Default [DF_AvisMembreBien_Approuve]    Script Date: 03/09/2015 15:20:04 ******/
ALTER TABLE [dbo].[AvisMembreBien] ADD  CONSTRAINT [DF_AvisMembreBien_Approuve]  DEFAULT ((0)) FOR [Approuve]