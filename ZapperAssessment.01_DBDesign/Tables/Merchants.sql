CREATE TABLE [dbo].[Merchants]
(
	[MerchantId] INT NOT NULL PRIMARY KEY, 
    [MerchantName] VARCHAR(200) NOT NULL, 
    [Email] VARCHAR(200) NOT NULL, 
    [ContactNumber] VARCHAR(20) NOT NULL, 
    [CreatedDateTime] DATETIME NOT NULL, 
    [ModifiedDateTime] DATETIME 
)
