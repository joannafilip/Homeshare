CREATE VIEW [dbo].[V_GetAllProperties]
	AS
SELECT 
	  BienEchange.idBien AS IdBien, 
	  titre, 
	  DescCourte, 
	  DescLong, 
	  NombrePerson, 
	  Pays.Libelle AS Libelle, 
	  Ville, Rue, Numero, 
	  CodePostal, 
	  Photo, 
	  AssuranceObligatoire, 
	  isEnabled, 
	  DisabledDate, 
	  Latitude, 
	  Longitude, 
	  idMembre, 
      DateCreation
FROM  BienEchange INNER JOIN Pays ON Pays.idPays = BienEchange.Pays
