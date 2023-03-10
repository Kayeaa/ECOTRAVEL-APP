CREATE TABLE [dbo].[Avis]
(
	[idAvis] INT IDENTITY NOT NULL, 
    [note] TINYINT NOT NULL, 
    [idLogement] INT NOT NULL, 
    [idClient] INT NOT NULL, 
    [message] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [PK_Avis] PRIMARY KEY ([idAvis]), 
    CONSTRAINT [FK_Avis_Logement] FOREIGN KEY ([idLogement]) REFERENCES [Logement]([idLogement]), 
    CONSTRAINT [FK_Avis_Client] FOREIGN KEY ([idClient]) REFERENCES[Client]([idClient]), 
    CONSTRAINT [CK_Avis_message] CHECK (LEN(message) >=1), 
    CONSTRAINT [CK_Avis_note] CHECK ((note <= 10) AND (note >=1))
)
