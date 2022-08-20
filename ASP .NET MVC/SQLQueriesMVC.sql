CREATE TABLE FootballLeague(
	MatchId int primary key identity(1001,1),
	TeamName1 nvarchar(30),
	TeamName2 nvarchar(30),
	Status nvarchar(5),
	WinningTeam  nvarchar(10) DEFAULT NULL,
	Points int
)

DROP TABLE FootballLeague

--Insert into FootballLeague values ('Japan','Russia','Win','Japan',4);
 
Create Procedure AddMatchResult(
@TeamName1 nvarchar(30),@TeamName2 nvarchar(30), @Status nvarchar(5), @WinningTeam nvarchar(10), @Points int, @MatchID int OUT)
AS
	BEGIN
	INSERT INTO FootballLeague VALUES (@TeamName1,@TeamName2,@Status,@WinningTeam,@Points)
	Select @MatchID = SCOPE_IDENTITY()
 END 