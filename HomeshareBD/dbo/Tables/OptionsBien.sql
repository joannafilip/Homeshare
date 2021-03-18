CREATE TABLE [dbo].[OptionsBien](
	[idOption] [int] NOT NULL,
	[idBien] [int] NOT NULL,
	[Valeur] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_OptionsBien] PRIMARY KEY CLUSTERED 
(
	[idOption] ASC,
	[idBien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_OptionsBien_BienEchange]    Script Date: 03/09/2015 15:20:04 ******/
ALTER TABLE [dbo].[OptionsBien]  WITH CHECK ADD  CONSTRAINT [FK_OptionsBien_BienEchange] FOREIGN KEY([idBien])
REFERENCES [dbo].[BienEchange] ([idBien])
GO

ALTER TABLE [dbo].[OptionsBien] CHECK CONSTRAINT [FK_OptionsBien_BienEchange]
GO
/****** Object:  ForeignKey [FK_OptionsBien_Options]    Script Date: 03/09/2015 15:20:04 ******/
ALTER TABLE [dbo].[OptionsBien]  WITH CHECK ADD  CONSTRAINT [FK_OptionsBien_Options] FOREIGN KEY([idOption])
REFERENCES [dbo].[Options] ([idOption])
GO

ALTER TABLE [dbo].[OptionsBien] CHECK CONSTRAINT [FK_OptionsBien_Options]