CREATE PROCEDURE [dbo].[SP_ReservationAdd]
	@checkIn DATETIME,
	@checkOut DATETIME,
	@adulte TINYINT,
	@enfant TINYINT,
	@assurance BIT,
	@dateAnnulation DATE NULL,
	@annulationProprietaire BIT NULL
AS
	INSERT INTO [Reservation] ([checkIn],[checkOut], [adulte],[enfant],[assurance],[dateAnnulation], [annulationProprietaire])
	OUTPUT [inserted].[idReservation]
	VALUES (@checkIn, @checkOut, @adulte, @enfant, @assurance,@dateAnnulation, @annulationProprietaire)