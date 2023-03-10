CREATE TABLE [dbo].[Client]
(
	[idClient] INT IDENTITY NOT NULL, 
    [nom] NVARCHAR(50) NOT NULL, 
    [prenom] NVARCHAR(50) NOT NULL, 
    [email] NVARCHAR(255) NOT NULL, 
    [pays] NVARCHAR(50) NOT NULL, 
    [telephone] NVARCHAR(20) NOT NULL, 
    [password] VARBINARY(64) NOT NULL, 
    CONSTRAINT [PK_Client] PRIMARY KEY ([idClient]),
    CONSTRAINT [CK_Client_nom] CHECK (LEN([nom]) >= 1), 
    CONSTRAINT [CK_Client_prenom] CHECK (LEN([prenom]) >= 1), 
    CONSTRAINT [CK_Client_email] CHECK (LEN(email)>1), 
    CONSTRAINT [CK_Client_pays] CHECK (LEN(pays)>=1), 
    CONSTRAINT [CK_Client_telephone] CHECK (LEN(telephone)>=4 AND isNumeric(replace( telephone, '+','00'))=1)
)
GO
CREATE UNIQUE INDEX [UK_Client_email] ON [dbo].[Client] ([email])