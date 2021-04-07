CREATE VIEW [dbo].[Vue_MeilleursAvis]
AS
--SELECT     TOP (5) PERCENT dbo.BienEchange.idBien, dbo.BienEchange.titre, dbo.BienEchange.DescCourte, dbo.BienEchange.DescLong, dbo.BienEchange.NombrePerson, dbo.BienEchange.Pays, 
--                      dbo.BienEchange.Ville, dbo.BienEchange.Rue, dbo.BienEchange.Numero, dbo.BienEchange.CodePostal, dbo.BienEchange.Photo AS Photo, dbo.BienEchange.AssuranceObligatoire, dbo.AvisMembreBien.note AS Note,
--                      dbo.BienEchange.isEnabled, dbo.BienEchange.DisabledDate, dbo.BienEchange.Latitude, dbo.BienEchange.Longitude, dbo.BienEchange.idMembre AS IdMembre, dbo.BienEchange.DateCreation
--FROM         dbo.AvisMembreBien INNER JOIN
--                      dbo.BienEchange ON dbo.AvisMembreBien.idBien = dbo.BienEchange.idBien

SELECT TOP(5)
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
      BienEchange.DateCreation AS DateCreation,
	  AvisMembreBien.note AS Note
FROM  BienEchange INNER JOIN Pays ON Pays.idPays = BienEchange.Pays 
INNER JOIN Membre ON Membre.idMembre = BienEchange.idMembre
INNER JOIN AvisMembreBien ON AvisMembreBien.idBien = BienEchange.idBien
WHERE     (Note > 6)
ORDER BY Note DESC