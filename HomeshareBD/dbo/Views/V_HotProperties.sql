CREATE VIEW [dbo].[V_HotProperties]
	AS SELECT TOP (4) * FROM dbo.[V_GetAllProperties]
ORDER BY DateCreation DESC