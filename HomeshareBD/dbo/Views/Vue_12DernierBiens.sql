CREATE VIEW [dbo].[Vue_12DernierBiens]
AS
SELECT TOP (12) * FROM dbo.[V_GetAllProperties]
ORDER BY DateCreation DESC