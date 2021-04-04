﻿CREATE TABLE [dbo].[Message]
(
	[IdMessage] INT NOT NULL IDENTITY,
	Prenom NVARCHAR(50) NOT NULL,
	Nom NVARCHAR(50) NOT NULL,
	Email NVARCHAR(323) NOT NULL,
	[Message] NVARCHAR(150)  NOT NULL,
	[DateEnvoie] DATETIME NOT NULL 
	PRIMARY KEY CLUSTERED ([IdMessage] ASC),
)
