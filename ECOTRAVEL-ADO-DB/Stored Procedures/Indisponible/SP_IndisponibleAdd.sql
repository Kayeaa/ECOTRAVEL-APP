CREATE PROCEDURE [dbo].[SP_IndisponibleAdd]
	@dateCommencement DATE,
	@dateFin DATE
AS
	INSERT INTO [Indisponible] ([dateCommencement], [dateFin])
	OUTPUT [inserted].[idIndisponible]
	VALUES (@dateCommencement, @dateFin)
