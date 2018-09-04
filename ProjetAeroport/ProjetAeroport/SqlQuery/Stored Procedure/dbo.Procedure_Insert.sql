CREATE PROCEDURE [dbo].[Insert_Vol]
	@ID varchar(7),
	@DESTINATION varchar(30),
	@ETAT varchar(10),
	@LOGO varchar(75),
	@PREVU varchar(10),
	@REVISE varchar(10),
	@PORTE varchar(5),
	@DATE datetime,
	@TYPEVOL varchar(20)
	
AS
	insert into [dbo].[Vol](
	[ID],
	[DESTINATION],
	[ETAT],
	[LOGO],
	[PREVU],
	[REVISE],
	[PORTE],
	[DATE],
	[TYPEVOL]
	) values (
	@ID,
	@DESTINATION,
	@ETAT,
	@LOGO,
	@PREVU,
	@REVISE,
	@PORTE,
	@DATE,
	@TYPEVOL
	)
go
