--CREATE DATABASE AdoptionDB;
--USE AdoptionDB;

--CREATE TABLE Cats (
--	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
--	Img NVARCHAR(255),
--	[Name] NVARCHAR(50),
--	[Description] NVARCHAR(4000), 
--	Age INT, 
--	AgeCategory NVARCHAR(255),
--	Breed NVARCHAR(255),
--	Fixed BIT, 
--	);

--INSERT INTO Cats(Img, [Name], [Description], Age, AgeCategory, Breed, Fixed)
--VALUES ('https://unsplash.com/photos/-81lVsfM4gQ', 'Puffer Face', 'Very fluffy and puffy', 4, 'Adult', 'Domestic Shorthair', 1),
--('https://images.unsplash.com/flagged/photo-1557427705-88c1e5a11a52?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1770&q=80', 'Majik', 'Green eyed, white and furry. Don"t let him judge you.', 8, 'Adult', 'Domestic Longhair', 1),
--('https://unsplash.com/photos/oU6KZTXhuvk', 'Sir Sassafrass', 'Sir Sassafrass is a bit confused, but he will definately make a great friend.', 1, 'Kitten', 'Domestic Shorthair', 0),
-- ('https://images.unsplash.com/photo-1604916287784-c324202b3205?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=654&q=80', 'Esmerelda', 'Black beauty', 5, 'Adult', 'Domestic Shorthair', 1),
--('https://images.unsplash.com/photo-1547565295-182fb8657b6b?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2069&q=80', 'Jessica', 'Shy at first but very friendly. Jessica is looking for a new home.', 1, 'Kitten', 'Domestic Hairless', 0);


SELECT * FROM Cats;



----CREATE TABLE DetailsTable (
----	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
----	Cals INT, 
----	ProductId INT NOT NULL FOREIGN KEY REFERENCES ProductTable(id)
----	);
--INSERT INTO DetailsTable(Cals, ProductID)
--VALUES (552, 1),
--(35, 2),
--(750, 3);

--SELECT * FROM DetailsTable;
