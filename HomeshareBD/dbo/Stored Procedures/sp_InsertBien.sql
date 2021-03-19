CREATE PROCEDURE [dbo].[sp_InsertBien]
	@titre NVARCHAR (50),
	@descCourte NVARCHAR (150),
	@descLong NTEXT,
	@nombrePerson INT,
	@idPays INT,
	@ville NVARCHAR (50),
	@rue NVARCHAR (50),
	@numero NVARCHAR (5),
	@codePostal NVARCHAR (50),
	@photo NVARCHAR (50),
	@assuranceObligatoire BIT,
	@isEnabled BIT,
	@disabledDate DATE,
	@latitude NVARCHAR (50),
	@longitude NVARCHAR (50),
	@dateCreation DATE,
	@idMembre INT
AS
	INSERT INTO [BienEchange]([Titre], [DescCourte], [DescLong], [NombrePerson], [Pays], [Ville], [Rue],[Numero], [CodePostal], [Photo], [AssuranceObligatoire], [isEnabled], [DisabledDate], [Latitude], [Longitude],[DateCreation], [idMembre])
	OUTPUT inserted.idBien
	VALUES (@titre, @descCourte, @descLong, @nombrePerson, @idPays, @ville, @rue, @numero, @codePostal, @photo, @assuranceObligatoire, @isEnabled, @disabledDate, @latitude, @longitude, GETDATE(), @idMembre)
