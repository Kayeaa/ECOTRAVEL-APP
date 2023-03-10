CREATE PROCEDURE [dbo].[SP_FactureAdd]
	@prix MONEY,
	@prixSejour MONEY,
	@prixAnnulation MONEY NULL,
	@dateFacturation DATE
AS
	INSERT INTO [Facture] ([prix], [prixSejour], [prixAnnulation], [dateFacturation])
	OUTPUT [inserted].[idFacture]
	VALUES (@prix, @prixSejour, @prixAnnulation, @dateFacturation)

