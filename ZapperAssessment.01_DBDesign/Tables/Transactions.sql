CREATE TABLE [dbo].[Transactions]
(
	[TransactionId] INT NOT NULL PRIMARY KEY, 
	[CustomerId] INT NOT NULL, 
	[MerchantId] INT NOT NULL, 
    [TransactionDateTime] DATETIME NOT NULL, 
    [TransactionAmount] Decimal(18, 2) NOT NULL, 
    FOREIGN KEY (CustomerId) REFERENCES [dbo].[Customers](CustomerId),
    FOREIGN KEY (MerchantId) REFERENCES [dbo].[Merchants](MerchantId) 
)
