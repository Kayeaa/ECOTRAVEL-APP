CREATE PROCEDURE [dbo].[SP_AvisAdd]
	@note TINYINT,
	@message NVARCHAR(MAX)
AS
	INSERT INTO [Avis] ([note], [message])
	OUTPUT [inserted].[idAvis]
	VALUES (@note, @message)
