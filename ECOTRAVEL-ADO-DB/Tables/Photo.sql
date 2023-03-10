CREATE TABLE [dbo].[Photo]
(
	[idPhoto] INT IDENTITY NOT NULL, 
    [url] NVARCHAR(255) NOT NULL, 
    [idLogement] INT NOT NULL, 
    CONSTRAINT [PK_Photo] PRIMARY KEY ([idPhoto]), 
    CONSTRAINT [FK_Photo_Logement] FOREIGN KEY ([idLogement]) REFERENCES [Logement]([idLogement]), 
    CONSTRAINT [CK_Photo_url] CHECK (LEN(url)>=1) 
)
