
USE [master]
GO

/****** Object:  Database [HomeShareDBASP]    Script Date: 03/09/2015 15:20:04 ******/
CREATE DATABASE [HomeShareDBASP] ;
GO

USE [HomeShareDBASP]
GO

/****** Object:  Table [dbo].[Options]    Script Date: 03/09/2015 15:20:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET IDENTITY_INSERT [dbo].[Options] ON
GO

INSERT [dbo].[Options] ([idOption], [Libelle]) VALUES (1, N'Chien admis')
GO

INSERT [dbo].[Options] ([idOption], [Libelle]) VALUES (2, N'Lave Linge')
GO

INSERT [dbo].[Options] ([idOption], [Libelle]) VALUES (3, N'Lave vaisselle')
GO

INSERT [dbo].[Options] ([idOption], [Libelle]) VALUES (4, N'Wifi')
GO

INSERT [dbo].[Options] ([idOption], [Libelle]) VALUES (5, N'Parking')
GO

INSERT [dbo].[Options] ([idOption], [Libelle]) VALUES (6, N'Piscine')
GO

INSERT [dbo].[Options] ([idOption], [Libelle]) VALUES (7, N'Feu ouvert')
GO

INSERT [dbo].[Options] ([idOption], [Libelle]) VALUES (8, N'Lit enfant')
GO

INSERT [dbo].[Options] ([idOption], [Libelle]) VALUES (9, N'WC')
GO

INSERT [dbo].[Options] ([idOption], [Libelle]) VALUES (10, N'Salle de bain')
GO

SET IDENTITY_INSERT [dbo].[Options] OFF
GO

/****** Object:  Table [dbo].[Pays]    Script Date: 03/09/2015 15:20:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET IDENTITY_INSERT [dbo].[Pays] ON
GO

INSERT [dbo].[Pays] ([idPays], [Libelle]) VALUES (1, N'Belgique')
GO

INSERT [dbo].[Pays] ([idPays], [Libelle]) VALUES (2, N'France')
GO

INSERT [dbo].[Pays] ([idPays], [Libelle]) VALUES (3, N'Italie')
GO

INSERT [dbo].[Pays] ([idPays], [Libelle]) VALUES (4, N'Pays-Bas')
GO

INSERT [dbo].[Pays] ([idPays], [Libelle]) VALUES (5, N'Luxembourg')
GO

INSERT [dbo].[Pays] ([idPays], [Libelle]) VALUES (6, N'Austalie')
GO

INSERT [dbo].[Pays] ([idPays], [Libelle]) VALUES (7, N'USA')
GO

INSERT [dbo].[Pays] ([idPays], [Libelle]) VALUES (8, N'Anglettere')
GO

INSERT [dbo].[Pays] ([idPays], [Libelle]) VALUES (9, N'Espagne')
GO

INSERT [dbo].[Pays] ([idPays], [Libelle]) VALUES (10, N'Portugal')
GO

INSERT [dbo].[Pays] ([idPays], [Libelle]) VALUES (11, N'Islande')
GO

SET IDENTITY_INSERT [dbo].[Pays] OFF
GO

/****** Object:  Table [dbo].[Membre]    Script Date: 03/09/2015 15:20:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET IDENTITY_INSERT [dbo].[Membre] ON
GO

INSERT [dbo].[Membre] ([idMembre], [Nom], [Prenom], [Email], [Pays], [Telephone], [Login], [Password]) VALUES (1, N'Pink', N'Panther', N'pink@panther.com', 7, N'555-456325', N'Pink', N'Pink')
GO

INSERT [dbo].[Membre] ([idMembre], [Nom], [Prenom], [Email], [Pays], [Telephone], [Login], [Password]) VALUES (3, N'Admin', N'Admin', N'admin@HomeShare.be', 1, N'4562325214', N'Admin', N'Admin')
GO

INSERT [dbo].[Membre] ([idMembre], [Nom], [Prenom], [Email], [Pays], [Telephone], [Login], [Password]) VALUES (4, N'Dolphin', N'Flipper', N'dolphin.Flip@sea.us', 6, N'0000000000', N'Dol', N'Phin')
GO

SET IDENTITY_INSERT [dbo].[Membre] OFF
GO

/****** Object:  Table [dbo].[BienEchange]    Script Date: 03/09/2015 15:20:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET IDENTITY_INSERT [dbo].[BienEchange] ON
GO

INSERT [dbo].[BienEchange] ([idBien], [titre], [DescCourte], [DescLong], [NombrePerson], [Pays], [Ville], [Rue], [Numero], [CodePostal], [Photo], [AssuranceObligatoire], [isEnabled], [DisabledDate], [Latitude], [Longitude], [idMembre], [DateCreation]) VALUES (2, N'Un peu Humide', N'Petite maison sous-marine tout confort', N'Maison tout confort située au large de Miami. <br /> Possibilité de venir avec votre animal de compagnie si celui-ci adore les longs séjours dans l''eau ou si il est naturellement amphibie. Pas de piscine mais une magnifique serre contenant algues et anémones.', 2, 6, N'Miami', N'UnderStreet', N'8', N'123456', N'maisonSousMarine.jpg', 0, 1, NULL, N'25.774', N'36.874', 1, CAST(0xAE390B00 AS Date))
GO

INSERT [dbo].[BienEchange] ([idBien], [titre], [DescCourte], [DescLong], [NombrePerson], [Pays], [Ville], [Rue], [Numero], [CodePostal], [Photo], [AssuranceObligatoire], [isEnabled], [DisabledDate], [Latitude], [Longitude], [idMembre], [DateCreation]) VALUES (3, N'Vue imprenable sur le grand Canyon', N'Maison perchée sur la falaise offrant une vue imprenable.', N'Vivre comme un aigle et respirer l''air pur.<br > Cette maison est un petit paradis perché offran lt confort moderne.', 1, 7, N'Colorado Sping', N'RockNRoll', N'10', N'784521', N'rockHouse.jpg', 1, 1, NULL, N'36.159420', N'-112.202579', 3, CAST(0xAE390B00 AS Date))
GO

SET IDENTITY_INSERT [dbo].[BienEchange] OFF
GO

/****** Object:  Table [dbo].[AvisMembreBien]    Script Date: 03/09/2015 15:20:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET IDENTITY_INSERT [dbo].[AvisMembreBien] ON
GO

INSERT [dbo].[AvisMembreBien] ([idAvis], [note], [message], [idMembre], [idBien], [DateAvis], [Approuve]) VALUES (2, 4, N'Beaucoup trop humide', 1, 2, CAST(0x0000A45300000000 AS DateTime), 1)
GO

INSERT [dbo].[AvisMembreBien] ([idAvis], [note], [message], [idMembre], [idBien], [DateAvis], [Approuve]) VALUES (4, 10, N'Quel merveille', 4, 3, CAST(0x0000A45300000000 AS DateTime), 1)
GO

INSERT [dbo].[AvisMembreBien] ([idAvis], [note], [message], [idMembre], [idBien], [DateAvis], [Approuve]) VALUES (5, 1, N'Vraiment n''importe quoi ce bien', 1, 2, CAST(0x0000A45300000000 AS DateTime), 0)
GO

SET IDENTITY_INSERT [dbo].[AvisMembreBien] OFF
GO

/****** Object:  Table [dbo].[OptionsBien]    Script Date: 03/09/2015 15:20:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

INSERT [dbo].[OptionsBien] ([idOption], [idBien], [Valeur]) VALUES (1, 2, N'Oui')
GO

INSERT [dbo].[OptionsBien] ([idOption], [idBien], [Valeur]) VALUES (1, 3, N'Non')
GO

INSERT [dbo].[OptionsBien] ([idOption], [idBien], [Valeur]) VALUES (2, 2, N'Non')
GO

INSERT [dbo].[OptionsBien] ([idOption], [idBien], [Valeur]) VALUES (3, 3, N'Non')
GO

INSERT [dbo].[OptionsBien] ([idOption], [idBien], [Valeur]) VALUES (4, 2, N'Oui')
GO

INSERT [dbo].[OptionsBien] ([idOption], [idBien], [Valeur]) VALUES (6, 2, N'Oui')
GO

INSERT [dbo].[OptionsBien] ([idOption], [idBien], [Valeur]) VALUES (8, 3, N'1')
GO

INSERT [dbo].[OptionsBien] ([idOption], [idBien], [Valeur]) VALUES (9, 2, N'1')
GO

INSERT [dbo].[OptionsBien] ([idOption], [idBien], [Valeur]) VALUES (10, 2, N'5')
GO

/****** Object:  Table [dbo].[MembreBienEchange]    Script Date: 03/09/2015 15:20:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[sp_RecupBienMembre]    Script Date: 03/09/2015 15:20:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  View [dbo].[Vue_CinqDernierBiens]    Script Date: 03/09/2015 15:20:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  View [dbo].[Vue_BiensParPays]    Script Date: 03/09/2015 15:20:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  View [dbo].[Vue_MeilleursAvis]    Script Date: 03/09/2015 15:20:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[sp_RecupToutesInfosBien]    Script Date: 03/09/2015 15:20:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[sp_RecupBienDispo]    Script Date: 03/09/2015 15:20:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
