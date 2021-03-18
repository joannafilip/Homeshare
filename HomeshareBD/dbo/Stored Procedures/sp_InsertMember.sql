CREATE PROCEDURE [dbo].[sp_InsertMember]
@nom NVARCHAR (50),
	@prenom NVARCHAR (50),
	@email NVARCHAR (256) ,
	@login NVARCHAR(50),
	@password NVARCHAR(256),
	@telephone NVARCHAR(20),
	@idPays INT

AS
DECLARE @salt CHAR(8)
	SET @salt = [dbo].SF_GenerateSalt()
	INSERT INTO [Membre]([Nom], [Prenom], [Email], [Login], [Password], [Salt], [Telephone],[Pays] )
	OUTPUT inserted.IdMembre
	VALUES (@nom, @prenom, @email, @login, dbo.SF_EncryptedPassword(@password, @salt),@salt, @telephone, @idPays)
