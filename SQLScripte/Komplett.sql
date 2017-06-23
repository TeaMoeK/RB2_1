CREATE TABLE [SchiessKlassen]
(      [ID] INT PRIMARY KEY NOT NULL IDENTITY,
       [KlassenName] VARCHAR(50) NOT NULL,
       [AnzahlSchuss] INTEGER,
       [JahrgangVon] INTEGER,
       [JahrgangBis] INTEGER,
       [AlterVon] INTEGER,
       [AlterBis] INTEGER,
       [IstArchiviert] INTEGER NOT NULL DEFAULT 0,
       [Geschlecht] char(1)
)
	   
CREATE TABLE [SchiessArten]
(      [ID] INT PRIMARY KEY NOT NULL IDENTITY,
       [SchiessArt] VARCHAR(50) NOT NULL,
       [IstArchiviert] INTEGER NOT NULL DEFAULT 0
)

CREATE TABLE [KlassenArten]
(
	[SchiessKlassenID] INT NOT NULL,
	[SchiessArtenID] INT NOT NULL,
	PRIMARY KEY (SchiessKlassenID, SchiessArtenID)
)

CREATE TABLE [Material]
(
    [ID] INT PRIMARY KEY NOT NULL IDENTITY,
    [MaterialGruppenID] int NOT NULL, 
    [Bezeichnung] char(32), 
    [Langtext] char(32), 
    [Groesse] char(32)
)

CREATE TABLE [MaterialGruppen]
(
	[ID] INT PRIMARY KEY NOT NULL IDENTITY,
	[Bezeichnung] char(32)
)
	
CREATE TABLE [Adressen]
(
	[ID] INTEGER PRIMARY KEY NOT NULL IDENTITY,
	[Strasse] VARCHAR(30) NOT NULL,
	[Stadt] VARCHAR(30) NOT NULL,
	[Land] VARCHAR(30) DEFAULT 'Deutschland',
	[PLZ] INTEGER NOT NULL
)

CREATE TABLE [Personen]
(
    [ID] INT PRIMARY KEY NOT NULL IDENTITY,
    [AdressID] INT NOT NULL DEFAULT -1, 
    [Vorname] char(24) NOT NULL, 
    [Zweitname] char(24), 
    [Nachname] char(24) NOT NULL, 
    [Geburtstag] date NOT NULL DEFAULT '01.01.1900 00:00:00.000', 
    [Geschlecht] char(1) NOT NULL DEFAULT 'x', 
    [DarfKK] BIT DEFAULT 0, 
    [DarfLG] BIT DEFAULT 0, 
    [KleinkaliberID] int DEFAULT -1, 
    [LuftgewehrID] int DEFAULT -1, 
    [HandschuhID] int DEFAULT -1, 
    [JackeID] int DEFAULT -1,
    [PistoleID] INT DEFAULT -1, 
    [Info] VARCHAR(1024), 
    [IstKoenig] BIT DEFAULT 0,
    [IstVize] BIT DEFAULT 0, 
    [IstArchiviert] BIT DEFAULT 0
)
	
CREATE TABLE [Ergebnisse]
(
    [ID] INT PRIMARY KEY NOT NULL IDENTITY,
    [NamenID] int NOT NULL, 
    [Datum] DATE NOT NULL, 
    [Satz1] NVARCHAR(18) NOT NULL, 
    [Satz2] NVARCHAR(18), 
    [Satz3] NVARCHAR(18), 
    [Satz4] NVARCHAR(18), 
    [SchiessArtenID] INTEGER NOT NULL, 
    [Info] nvarchar(128),
    [IstArchiviert] BIT NOT NULL  DEFAULT 0
)
	
CREATE TABLE [Koenige]
(
	[Koenig] varchar(10) UNIQUE NOT NULL CHECK (Koenig IN('JKoenig', 'JVize', 'KKoenig', 'KVize')),
	[Person] INT UNIQUE FOREIGN KEY REFERENCES Personen(ID)
)
	
CREATE TABLE [Verschiedenes]
(
    [ID] INT PRIMARY KEY NOT NULL IDENTITY,
    [Schuetzenfest] DATE DEFAULT '01.01.1900 00:00:00.000' NOT NULL, 
    [Password] TEXT
)
	

INSERT INTO MaterialGruppen
	(Bezeichnung)
VALUES
	('Handschuhe'),
	('Jacken'),
	('Kleinkaliber'),
	('Luftgewehr'),
	('Pistole')
