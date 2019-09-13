# InOne.Tasks
!!! DB for FootBallAndADO !!!

CREATE DATABASE FootBallDB;

USE FootBallDB

CREATE TABLE Coachs
(
[Id][int] PRIMARY KEY IDENTITY(1,1),
[FullName][nvarchar](75) NOT NULL,
[Age][tinyint] NULL 
)

CREATE TABLE Teams
(
[Id][int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
[Name][nvarchar](100) NOT NULL,
[Coach_Id][int] NULL
FOREIGN KEY (Coach_Id) REFERENCES Coach(Id) 
)

CREATE TABLE Players
(
[Id][int] PRIMARY KEY IDENTITY (1,1),
[Name][nvarchar](50) NOT NULL,
[SurName][nvarchar](75) NOT NULL,
[Number][tinyint] NOT NULL,
[Team_Id][int] NULL,
FOREIGN KEY (Team_Id) REFERENCES Teams(Id)
)


INSERT INTO Coachs (FullName) Values ('Ernesto Valderde'), ('J. Klopp'), ('Guardiola'),('Marcelino'),('Mauricio Pochettino');
INSERT INTO Coachs (FullName,Age) VALUES ('James Franklin', 47), ('José Mourinho', 56);
INSERT INTO Coachs (FullName) VALUES ('Ole Gunnar Solskjær');
INSERT INTO Teams (Name, Coach_Id) VALUES ('FC Barcelona', 1), ('Manchester United F.C.', 8), ('Manchester City F.C.',3),('Liverpool F.C.',2);
INSERT INTO Players (Name, SurName, Number, Team_Id) VALUES ('Lionel','Messi', 11, 1),('Sergio','Agüero',8 , 4),('Paul','Pogba',15 , 2),
('Harry','Maguire', 5, 2),('Sadio','Mane',10 , 4),('Antoine','Griezmann', 7, 1),('Ivan','Rakitić', 7, 1),('Gerard','Piqué', 3, 1);


SELECT Teams.[Name] FROM Teams 
FULL JOIN Players p 
ON p.Team_Id = Teams.Id
GROUP BY Teams.[Name]
HAVING Count(Teams.Id) >= 2
