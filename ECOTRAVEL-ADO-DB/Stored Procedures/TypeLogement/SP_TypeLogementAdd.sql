CREATE PROCEDURE [dbo].[SP_TypeLogementAdd]
	@nom NVARCHAR(50)
AS
	INSERT INTO [TypeLogement] ([nom])
	OUTPUT [inserted].[idTypeLogement]
	VALUES (@nom)
