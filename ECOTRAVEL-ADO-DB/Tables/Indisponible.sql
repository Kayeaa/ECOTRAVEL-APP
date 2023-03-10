CREATE TABLE [dbo].[Indisponible]
(
	[idIndisponible] INT iDENTITY NOT NULL, 
    [idLogement] INT NOT NULL, 
    [dateCommencement] DATE NOT NULL, 
    [dateFin] DATE NOT NULL, 
    CONSTRAINT [PK_Indisponible] PRIMARY KEY ([idIndisponible]),
     CONSTRAINT [CK_Indisponible_dateCommencement] CHECK ([dateCommencement] >= GETDATE()), 
     CONSTRAINT [CK_Indisponible_dateFin] CHECK ([dateFin] > [dateCommencement]), 
    CONSTRAINT [FK_Indisponible_Logement] FOREIGN KEY ([idLogement]) REFERENCES [Logement]([idLogement])
)
