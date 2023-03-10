CREATE TABLE [dbo].[Logement]
(
	[idLogement] INT IDENTITY NOT NULL, 
    [nom] NVARCHAR(255) NOT NULL, 
    [boite] NVARCHAR(5) NOT NULL, 
    [numero] NVARCHAR(10) NOT NULL, 
    [rue] NVARCHAR(250) NOT NULL, 
    [pays] NVARCHAR(50) NOT NULL, 
    [coordLatitude] DECIMAL(10,7) NOT NULL, 
    [coordLongitude] DECIMAL(10,7) NOT NULL, 
    [descriptionCourte] NVARCHAR(140) NOT NULL, 
    [descriptionLongue] NVARCHAR(MAX) NOT NULL, 
    [chambre] TINYINT NOT NULL, 
    [piece] TINYINT NOT NULL, 
    [capacite] TINYINT NOT NULL, 
    [salledeBain] TINYINT NOT NULL, 
    [wc] TINYINT NOT NULL, 
    [balcon] BIT NOT NULL, 
    [airConditionne] BIT NOT NULL, 
    [wifi] BIT NOT NULL, 
    [minibar] BIT NOT NULL, 
    [animaux] BIT NOT NULL, 
    [piscine] BIT NOT NULL, 
    [voiturier] BIT NOT NULL, 
    [roomService] BIT NOT NULL, 
    [prix] MONEY NOT NULL, 
    [idTypeLogement] INT NOT NULL, 
    [idProprietaire] INT NOT NULL, 
    CONSTRAINT [PK_Logement] PRIMARY KEY ([idLogement]), 
    CONSTRAINT [FK_Logement_TypeLogement] FOREIGN KEY ([idTypeLogement]) REFERENCES [TypeLogement]([idTypeLogement]), 
    CONSTRAINT [FK_Logement_Proprietaire] FOREIGN KEY ([idProprietaire]) REFERENCES [Proprietaire]([idClient]), 
    CONSTRAINT [CK_Logement_nom] CHECK (LEN(nom)>=1), 
    CONSTRAINT [CK_Logement_boite] CHECK (LEN(boite)>=1), 
    CONSTRAINT [CK_Logement_numero] CHECK (LEN(numero)>=1), 
    CONSTRAINT [CK_Logement_rue] CHECK (LEN(rue)>=1), 
    CONSTRAINT [CK_Logement_pays] CHECK (LEN(pays)>=1), 
    CONSTRAINT [CK_Logement_descriptionCourte] CHECK (LEN(descriptionCourte)>=1), 
    CONSTRAINT [CK_Logement_decriptionLongue] CHECK (LEN(descriptionLongue)>=LEN(descriptionCourte))
)

GO

CREATE UNIQUE INDEX [UK_Logement_idTypeLogement] ON [dbo].[Logement]([idLogement])
