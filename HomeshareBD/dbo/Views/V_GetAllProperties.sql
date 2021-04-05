CREATE VIEW [dbo].[V_GetAllProperties]
	AS
SELECT 
	  BienEchange.idBien AS IdBien, 
	  BienEchange.titre AS Titre, 
	  DescCourte, 
	  DescLong, 
	  NombrePerson, 
	  Pays.Libelle AS Libelle, 
	  Ville, 
	  Rue, 
	  Numero, 
	  CodePostal, 
	  Photo, 
	  AssuranceObligatoire, 
	  BienEchange.isEnabled AS IsEnabled, 
	  DisabledDate, 
	  Latitude, 
	  Longitude, 
	  BienEchange.idMembre AS IdMembre, 
      DateCreation
FROM  BienEchange INNER JOIN Pays ON Pays.idPays = BienEchange.Pays
