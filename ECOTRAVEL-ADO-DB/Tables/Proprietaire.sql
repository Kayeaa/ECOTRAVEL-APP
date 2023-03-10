CREATE TABLE [dbo].[Proprietaire]
(
	[IdClient] INT NOT NULL, 
    CONSTRAINT [PK_Proprietaire] PRIMARY KEY ([IdClient]), 
    CONSTRAINT [FK_Proprietaire_Client] FOREIGN KEY ([idClient]) REFERENCES [Client]([idClient]) 
)
