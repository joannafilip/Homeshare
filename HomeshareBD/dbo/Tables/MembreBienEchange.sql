CREATE TABLE [dbo].[MembreBienEchange](
	[idMembre] [int] NOT NULL,
	[idBien] [int] NOT NULL,
	[DateDebEchange] [date] NOT NULL,
	[DateFinEchange] [date] NOT NULL,
	[Assurance] [bit] NULL,
	[Valide] [bit] NOT NULL,
 CONSTRAINT [PK_MembreBienEchange] PRIMARY KEY CLUSTERED 
(
	[idMembre] ASC,
	[idBien] ASC,
	[DateDebEchange] ASC,
	[DateFinEchange] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_MembreBienEchange_BienEchange]    Script Date: 03/09/2015 15:20:04 ******/
ALTER TABLE [dbo].[MembreBienEchange]  WITH CHECK ADD  CONSTRAINT [FK_MembreBienEchange_BienEchange] FOREIGN KEY([idBien])
REFERENCES [dbo].[BienEchange] ([idBien])
GO

ALTER TABLE [dbo].[MembreBienEchange] CHECK CONSTRAINT [FK_MembreBienEchange_BienEchange]
GO
/****** Object:  ForeignKey [FK_MembreBienEchange_membre]    Script Date: 03/09/2015 15:20:04 ******/
ALTER TABLE [dbo].[MembreBienEchange]  WITH CHECK ADD  CONSTRAINT [FK_MembreBienEchange_membre] FOREIGN KEY([idMembre])
REFERENCES [dbo].[Membre] ([idMembre])
GO

ALTER TABLE [dbo].[MembreBienEchange] CHECK CONSTRAINT [FK_MembreBienEchange_membre]
GO
/****** Object:  Default [DF_MembreBienEchange_Valide]    Script Date: 03/09/2015 15:20:04 ******/
ALTER TABLE [dbo].[MembreBienEchange] ADD  CONSTRAINT [DF_MembreBienEchange_Valide]  DEFAULT ((0)) FOR [Valide]