CREATE TABLE [dbo].[TodoItems]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [LijstId] INT NULL, 
    [Naam] NVARCHAR(200) NOT NULL, 
    [TegenWanneer] DATETIME NOT NULL, 
    [WanneerKlaar] DATETIME NULL, 
    CONSTRAINT [FK_TodoItems_TodoLijsten] FOREIGN KEY ([LijstId]) REFERENCES [TodoLijsten]([LijstId])
)
