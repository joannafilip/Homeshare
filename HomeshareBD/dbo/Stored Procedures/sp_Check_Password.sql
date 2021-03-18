﻿CREATE PROCEDURE [dbo].[SP_Check_Password]
	@login NVARCHAR (50),
	@password NVARCHAR(256)
	
AS
	DECLARE @hPassword NVARCHAR(256)
	DECLARE @salt CHAR(8)
	DECLARE @newPassword NVARCHAR(256)
	SELECT @salt = salt, @hPassword = Password FROM Membre WHERE login = @login
	SELECT @newPassword = dbo.SF_EncryptedPassword (@password, @salt)
	
	IF (@newPassword = @hPassword)
	BEGIN 
		SELECT [Login], Nom, Prenom, Email, Pays, Telephone FROM Membre WHERE login=@login 
	END 
