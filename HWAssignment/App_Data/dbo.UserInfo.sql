CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [firstName] VARCHAR(50) NOT NULL, 
    [lastName] VARCHAR(50) NOT NULL, 
    [address1] VARCHAR(100) NOT NULL, 
    [address2] VARCHAR(100) NULL, 
    [city] VARCHAR(50) NOT NULL, 
    [state] NCHAR(2) NOT NULL, 
    [zip] VARCHAR(9) NOT NULL, 
    [country] NCHAR(2) NOT NULL
)
