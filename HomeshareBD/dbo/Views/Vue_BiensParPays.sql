CREATE VIEW [dbo].[Vue_BiensParPays]
AS
SELECT     TOP (100) PERCENT idBien, titre, DescCourte, DescLong, NombrePerson, Pays, Ville, Rue, Numero, CodePostal, Photo, AssuranceObligatoire, isEnabled, DisabledDate, Latitude, Longitude, 
                      idMembre, DateCreation
FROM         dbo.BienEchange
ORDER BY Pays