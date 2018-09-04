CREATE PROCEDURE [dbo].SelectVol
	@TYPEVOL varchar,
	@DATE datetime
	
AS
	SELECT * from [dbo].Vol where TYPEVOL = @TYPEVOL and DATE = @DATE;
	go
