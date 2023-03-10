CREATE TABLE [dbo].[Reservation]
(
	[idReservation] INT IDENTITY NOT NULL, 
    [checkIn] DATETIME NOT NULL, 
    [checkOut] DATETIME NOT NULL, 
    [adulte] TINYINT NOT NULL, 
    [enfant] TINYINT NOT NULL, 
    [assurance] BIT NOT NULL, 
    [dateAnnulation] DATE NULL, 
    [annulationProprietaire] BIT NULL, 
    [idIndisponible] INT NOT NULL, 
    [idLogement] INT NOT NULL, 
    [idClient] INT NOT NULL, 
    CONSTRAINT [PK_Reservation] PRIMARY KEY ([idReservation]), 
    CONSTRAINT [FK_Reservation_Indisponible] FOREIGN KEY ([idIndisponible]) REFERENCES [Indisponible]([idIndisponible]), 
    CONSTRAINT [FK_Reservation_Logement] FOREIGN KEY ([idLogement]) REFERENCES [Logement]([idLogement]), 
    CONSTRAINT [FK_Reservation_Client] FOREIGN KEY ([idClient]) REFERENCES [Client]([idClient]), 
    CONSTRAINT [CK_Reservation_adulte] CHECK (LEN(adulte)>=1), 
    CONSTRAINT [CK_Reservation_enfant] CHECK (LEN(enfant)>=1)
)
