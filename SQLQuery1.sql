
USE ATMDB;
GO

CREATE TABLE Accounts
(
    AccountNumber VARCHAR(20) PRIMARY KEY,
    AccountHolder VARCHAR(100) NOT NULL,
    PIN VARCHAR(255) NOT NULL,
    Balance DECIMAL(12,2) NOT NULL DEFAULT 0,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    CONSTRAINT CK_Accounts_Balance CHECK (Balance >= 0)
);
GO

CREATE TABLE Transactions
(
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    AccountNumber VARCHAR(20) NOT NULL,
    TransactionType VARCHAR(20) NOT NULL,
    Amount DECIMAL(12,2) NOT NULL,
    TransactionDate DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    CONSTRAINT FK_Transactions_Accounts
        FOREIGN KEY (AccountNumber)
        REFERENCES Accounts(AccountNumber),
    CONSTRAINT CK_Transactions_Amount CHECK (Amount > 0)
);
GO
SELECT TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE';