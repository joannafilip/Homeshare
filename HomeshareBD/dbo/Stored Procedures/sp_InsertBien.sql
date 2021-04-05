CREATE PROCEDURE [dbo].[SP_InsertBien]
	@titre NVARCHAR (50),
	@descCourte NVARCHAR (150),
	@descLong NTEXT,
	@nombrePerson INT,
	@pays INT,
	@ville NVARCHAR (50),
	@rue NVARCHAR (50),
	@numero NVARCHAR (5),
	@codePostale NVARCHAR (50),
	@photo NVARCHAR (50),
	@assuranceObligatoire BIT,
	@isEnabled BIT,
	@latitude NVARCHAR (50),
	@longitude NVARCHAR (50),
	@idMembre INT
AS
	INSERT INTO [BienEchange]([Titre], [DescCourte], [DescLong], [NombrePerson], [Pays], [Ville], [Rue],[Numero], [CodePostal], [Photo], [AssuranceObligatoire], [isEnabled], [Latitude], [Longitude],[DateCreation], [idMembre])
	OUTPUT inserted.idBien
	VALUES (@titre, @descCourte, @descLong, @nombrePerson, @pays, @ville, @rue, @numero, @codePostale, @photo, @assuranceObligatoire, @isEnabled, @latitude, @longitude, GETDATE(), @idMembre)