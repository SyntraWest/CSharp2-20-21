CREATE TABLE [dbo].[TodoLijsten]
(
	[LijstId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Naam] NVARCHAR(100) NOT NULL, 
    [Eigenaar] NVARCHAR(100) NOT NULL, 
    CONSTRAINT [AK_TodoLijsten_Naam] UNIQUE ([Naam],[Eigenaar])
)
