CREATE TABLE [dbo].[Facture]
(
	[idFacture] INT IDENTITY NOT NULL,
    [idReservation] INT NOT NULL,
    [prix] MONEY NOT NULL, 
    [prixSejour] MONEY NOT NULL, 
    [prixAnnulation] MONEY NULL, 
    [dateFacturation] DATE NOT NULL, 
    CONSTRAINT [PK_Facture] PRIMARY KEY ([idFacture]), 
    CONSTRAINT [FK_Facture_Reservation] FOREIGN KEY ([idReservation]) REFERENCES [Reservation]([idReservation]) 
)
