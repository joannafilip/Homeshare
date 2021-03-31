-- =============================================
-- Author:		Cognitic 
-- Create date: 28/02/2015
-- Description:	Récupérer les biens d'un membre
-- =============================================
CREATE PROCEDURE [dbo].[sp_RecupBienMembre] 
	@idMembre int
AS
BEGIN
	select
        titre
       ,DescCourte
       ,DescLong
       ,NombrePerson
       ,Ville
       ,Rue
       ,Numero
       ,CodePostal
       ,Photo
       ,AssuranceObligatoire
       ,isEnabled
       ,DisabledDate
       ,Latitude
       ,Longitude
       ,idMembre
       ,DateCreation
       ,Pays.Libelle AS Libelle
       from BienEchange INNER JOIN Pays ON Pays.idPays = BienEchange.Pays
	where idMembre = @idMembre
END