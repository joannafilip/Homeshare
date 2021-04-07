CREATE VIEW [dbo].[V_GetAllProperties]
	AS
SELECT
	  BienEchange.idBien AS IdBien, 
	  BienEchange.titre AS Titre, 
	  BienEchange.Pays AS Pays,
	  DescCourte, 
	  DescLong, 
	  NombrePerson, 
	  Pays.Libelle AS Libelle, 
	  Ville, 
	  Rue, 
	  Numero, 
	  BienEchange.CodePostal AS CodePostale, 
	  BienEchange.Photo AS Photo,
	  AssuranceObligatoire, 
	  BienEchange.isEnabled AS IsEnabled, 
	  DisabledDate, 
	  Latitude, 
	  Longitude, 
	  BienEchange.idMembre AS IdMembre, 
      BienEchange.DateCreation AS DateCreation
FROM  BienEchange INNER JOIN Pays ON Pays.idPays = BienEchange.Pays 
INNER JOIN Membre ON Membre.idMembre = BienEchange.idMembre
