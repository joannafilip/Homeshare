CREATE TABLE [dbo].[Membre](
	[idMembre] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](50) NOT NULL,
	[Prenom] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](256) NOT NULL,
	[Pays] [int] NOT NULL,
	[Telephone] [nvarchar](20) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_membre] PRIMARY KEY CLUSTERED 
(
	[idMembre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]