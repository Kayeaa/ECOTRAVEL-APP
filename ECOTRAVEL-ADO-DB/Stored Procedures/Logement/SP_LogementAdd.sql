CREATE PROCEDURE [dbo].[SP_LogementAdd]
	@nom NVARCHAR(255),
	@boite NVARCHAR(50),
	@numero NVARCHAR(5),
	@rue NVARCHAR(250),
	@pays NVARCHAR(50),
	@coordLatitude DECIMAL,
	@coordLongitude DECIMAL,
	@descriptionCourte NVARCHAR(140),
	@descriptionLongue NVARCHAR(MAX),
	@chambre TINYINT,
	@piece TINYINT,
	@capacité TINYINT,
	@salledeBain TINYINT,
	@wc TINYINT,
	@balcon BIT,
	@airConditionne BIT,
	@wifi BIT,
	@minibar BIT,
	@animaux BIT,
	@piscine BIT,
	@voiturier BIT,
	@roomService BIT,
	@prix MONEY

AS
INSERT INTO [Logement] ([nom],[boite], [numero],[rue],[pays],[coordLatitude],[coordLongitude], [descriptionCourte], [descriptionLongue], [chambre],[piece], [capacite], [salledeBain], [wc], [balcon], [airConditionne], [wifi], [minibar], [animaux], [piscine], [voiturier], [roomService], [prix])
	OUTPUT [inserted].[idLogement]
	VALUES (@nom, @boite, @numero, @rue, @pays, @coordLatitude, @coordLongitude, @descriptionCourte, @descriptionLongue, @chambre, @piece, @capacité, @salledeBain, @wc, @balcon, @airConditionne, @wifi, @minibar, @animaux, @piscine, @voiturier, @roomService, @prix)
