# InOne.Tasks
!!! DB for FootBallAndADO !!!

CREATE DATABASE FootBallShoesDB;

USE FootBallDB

CREATE TABLE Coachs
(
[Id][int] PRIMARY KEY IDENTITY(1,1),
[FullName][nvarchar](75) NOT NULL,
[Age][int] NULL 
)

CREATE TABLE Teams
(
[Id][int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
[Name][nvarchar](100) NOT NULL,
[Coach_Id][int] NULL
FOREIGN KEY (Coach_Id) REFERENCES Coachs(Id) 
)

CREATE TABLE BrandNames
(
[Id][int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
[Name][nvarchar](50) NOT NULL
)

CREATE TABLE Players
(
[Id][int] PRIMARY KEY IDENTITY (1,1),
[Name][nvarchar](50) NOT NULL,
[SurName][nvarchar](75) NOT NULL,
[Number][tinyint] NOT NULL,
[FootSize][int] NOT NULL,
[Team_Id][int] NULL,

FOREIGN KEY (Team_Id) REFERENCES Teams(Id)
)


CREATE TABLE Shoes 
(
[Id][int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
[BrandName_Id][int] NOT NULL,
[Size][int] NOT NULL,
[Price][smallmoney] NOT NULL,
[DateOfCreation][datetime] NOT NULL,
[Player_Id][int] NULL,
FOREIGN KEY (BrandName_Id) REFERENCES BrandNames(Id),
FOREIGN KEY (Player_Id) REFERENCES Players(Id)
)



INSERT INTO BrandNames(Name) VALUES ('Nike'),('Guess'),('Crocs'),('DKNY'),('Clarks'),('UGG'),('Ecco'),('D&G'),('Born'),('Adidas');

INSERT INTO Coachs (FullName) Values ('Ernesto Valderde'), ('J. Klopp'), ('Guardiola'),('Marcelino'),('Mauricio Pochettino');
INSERT INTO Coachs (FullName,Age) VALUES ('James Franklin', 47), ('José Mourinho', 56);
INSERT INTO Coachs (FullName) VALUES ('Ole Gunnar Solskjær');
INSERT INTO Teams (Name, Coach_Id) VALUES ('FC Barcelona', 1), ('Manchester United F.C.', 8), ('Manchester City F.C.',3),('Liverpool F.C.',2);
INSERT INTO Players (Name, SurName, Number, Team_Id, FootSize) VALUES ('Lionel','Messi', 11, 1,41),('Sergio','Agüero',8 , 4, 42),('Paul','Pogba',15 , 2, 43),
('Harry','Maguire', 5, 2, 44),('Sadio','Mane',10 , 4, 40),('Antoine','Griezmann', 7, 1, 50),('Ivan','Rakitić', 7, 1, 45),('Gerard','Piqué', 3, 1, 55);
INSERT INTO Shoes(BrandName_Id, Size, Price,DateOfCreation, Player_Id) VALUES (1, 36, 20, '2020.6.6',1),(2,40,20.5,'2020.6.7',2),(2,40,20,'2010.5.5',3); 



SELECT Teams.[Name] FROM Teams 
FULL JOIN Players p 
ON p.Team_Id = Teams.Id
GROUP BY Teams.[Name]
HAVING Count(Teams.Id) >= 2
