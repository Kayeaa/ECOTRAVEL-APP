CREATE TABLE [dbo].[TypeLogement]
(
	[idTypeLogement] INT IDENTITY NOT NULL, 
    [nom] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_TypeLogement] PRIMARY KEY ([idTypeLogement]), 
    CONSTRAINT [CK_TypeLogement_nom] CHECK (LEN(nom)>=1)
)

GO

CREATE UNIQUE INDEX [IX_TypeLogement_nom] ON [dbo].[TypeLogement] ([nom])
