USE master
GO

if exists (select * from sysdatabases where name='PD1Movies')
	drop database PD1Movies
GO

CREATE DATABASE PD1Movies
GO

USE PD1Movies
GO

CREATE TABLE Movies(
	Id				INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	Title			VARCHAR(50) NOT NULL,
	ReleaseDate		DATE NOT NULL,
	Budget			MONEY NOT NULL,
	AvgRating		NUMERIC(18,2) NOT NULL,
	Imax3D			BIT NOT NULL,
	TicketsSold		INT NOT NULL
)

INSERT INTO Movies (Title, ReleaseDate, Budget, AvgRating, Imax3D, TicketsSold)
	VALUES ('Avatar', '2012-01-01', 50000000, 4.3, 1, 1252351),
		   ('Avengers', '2012-02-03', 2300000, 4.5, 1, 12347682),
		   ('Thor', '2011-09-24', 12, 3.4, 0, 234876),
		   ('Saw', '2004-01-19', 1200000, 4.0, 0, 523423),
		   ('Iron Man', '2008-04-14', 140000000, 5.0, 1, 15327496),
		   ('Guardians of the Galaxy', '2014-08-21', 170000000, 4.3, 0, 14754239);

SELECT * FROM Movies;