CREATE TABLE [dbo].[Customers]
(
	[CustomerId] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(200) NOT NULL, 
    [LastName] VARCHAR(200) NOT NULL, 
    [Email] VARCHAR(200) NOT NULL, 
    [ContactNumber] VARCHAR(20) NOT NULL, 
    [CreatedDateTime] DATETIME NOT NULL, 
    [ModifiedDateTime] DATETIME 
)
