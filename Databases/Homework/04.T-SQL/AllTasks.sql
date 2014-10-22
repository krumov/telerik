-- Task 1 Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) 
-- and Accounts(Id(PK), PersonId(FK), Balance). Insert few records for testing. 
-- Write a stored procedure that selects the full names of all persons.

CREATE DATABASE BankingSystem
GO

USE BankingSystem
GO

CREATE TABLE Persons (
        PersonsID INT IDENTITY,
        FirstName NVARCHAR(50),
        LastName NVARCHAR(50),
        SSN NVARCHAR(50)
        CONSTRAINT PK_PersonsID PRIMARY KEY(PersonsID)
)
 
CREATE TABLE Accounts (
        AccountID INT IDENTITY,
        PersonID INT,
        Balance money
        CONSTRAINT PK_AccountID PRIMARY KEY(AccountID)
        CONSTRAINT FK_PersonID FOREIGN KEY(PersonID)
                REFERENCES Persons(PersonsID)
)

GO

INSERT INTO Persons
VALUES
        ('Ivan','Ivanov',22244),
        ('Stoqn', 'Peshov', 323232),
        ('Pesho', 'Peshov', 098680),
        ('Mitio', 'Ninjata',3298432),
        ('Koko', 'Boksiora', 2894392)
 
INSERT INTO Accounts 
VALUES
        (2, 1000),
        (3, 2000),
        (4, 5),
        (1, 10)
GO

CREATE PROC dbo.ups_SelectPersonsFullName
AS
	SELECT FirstName +' '+ LastName as FullName
	FROM Persons
GO

EXEC dbo.ups_SelectPersonsFullName
GO

-- TASK 2 Create a stored procedure that accepts a number as a parameter and returns all persons
-- who have more money in their accounts than the supplied number.

CREATE PROC dbo.ups_SelectPersonsWithMoreMoneyThan(@amountToCompare money = 0)
AS
	SELECT p.PersonsID, a.TotalBalance as money
	FROM Persons p 
		INNER JOIN 
			(
				SELECT acc.PersonID, SUM (acc.Balance) AS TotalBalance
				FROM Accounts acc 
				GROUP BY acc.PersonID
			) 
			AS a 
		ON p.PersonsID=a.PersonID
	WHERE a.TotalBalance >= @amountToCompare
GO

EXEC dbo.ups_SelectPersonsWithMoreMoneyThan 6
GO

-- TASK 3 
-- Create a function that accepts as parameters – sum, yearly interest rate and number of months. 
-- It should calculate and return the new sum. Write a SELECT to test whether the function works as expected.

CREATE FUNCTION ufn_CalcInterest(@sum money, @interestRate decimal, @months decimal)
  RETURNS money
AS
	BEGIN
	  RETURN @sum + @sum*((@interestRate*@months/12)/100)
	END
GO

SELECT dbo.ufn_CalcInterest(100, 30, 6) as NewSum
GO

-- TASK 4
-- Create a stored procedure that uses the function from the previous example to give an interest 
-- to a person's account for one month. It should take the AccountId and the interest rate as parameters.

CREATE PROC dbo.ups_UpdateWithOneMonthInterest(@AccountID int, @interestRate decimal)
AS
	UPDATE Accounts
	SET Balance = dbo.ufn_CalcInterest(Balance, @interestRate, 1)
	WHERE AccountID=@AccountID
GO

EXEC dbo.ups_UpdateWithOneMonthInterest 1, 20.00; 
GO

-- TASK 5
-- Add two more stored procedures WithdrawMoney( AccountId, money) and 
-- DepositMoney (AccountId, money) that operate in transactions.

CREATE PROC dbo.ups_WithdrawMoney(@AccountID int, @money decimal)
AS
	BEGIN TRAN
	DECLARE @newBalance money

	IF NOT EXISTS(SELECT 1 FROM Accounts WHERE AccountID = @AccountID)
		BEGIN
			ROLLBACK TRAN
			RAISERROR('Incorrect AccountID', 16, 1)
		END
	ELSE
		BEGIN 
		SELECT @newBalance = Balance - @money
		FROM Accounts 
		WHERE AccountID=@AccountID
		IF(@newBalance<0)
			BEGIN
				ROLLBACK TRAN
				RAISERROR('Not enough money in account', 16, 1)
			END
		ELSE
			BEGIN
				UPDATE Accounts
				SET Balance = @newBalance
				WHERE AccountID=@AccountID
				COMMIT
			END
		END
GO

CREATE PROC dbo.ups_DepositMoney(@AccountID int, @money decimal)
AS
	BEGIN TRAN
	DECLARE @newBalance money

	IF NOT EXISTS(SELECT 1 FROM Accounts WHERE AccountID = @AccountID)
		BEGIN
			ROLLBACK TRAN
			RAISERROR('Incorrect AccountID', 16, 1)
		END
	ELSE
		BEGIN 
		SELECT @newBalance = Balance + @money
		FROM Accounts 
		WHERE AccountID=@AccountID
			UPDATE Accounts
			SET Balance = @newBalance
			WHERE AccountID=@AccountID
			COMMIT
		END
GO

-- Task 6. Create another table – Logs(LogID, AccountID, OldSum, NewSum).
-- Add a trigger to the Accounts table that enters a new entry into the Logs table every
-- time the sum on an account changes.

CREATE TABLE Logs
(
  LogID int IDENTITY,
  AccountID int NOT NULL,
  OldSum money,
  NewSum money,
  ChangeDate datetime,
  CONSTRAINT PK_LogID PRIMARY KEY(LogID)
)
GO

ALTER TABLE [dbo].[Logs]  WITH CHECK ADD  CONSTRAINT [FK_Logs_Accounts] FOREIGN KEY([AccountID])
REFERENCES [dbo].[Accounts] ([AccountID])
GO

CREATE TRIGGER tr_AccountsUpdate ON Accounts FOR UPDATE
AS
  INSERT INTO Logs (AccountID, OldSum, NewSum, ChangeDate)
  SELECT d.AccountID, d.Balance, i.Balance, GETDATE()
  FROM deleted d INNER JOIN inserted i on d.AccountID = i.AccountID
GO

CREATE TRIGGER tr_AccountsInsert ON Accounts FOR INSERT
AS
  INSERT INTO Logs (AccountID, OldSum, NewSum, ChangeDate)
  SELECT i.AccountID, NULL, i.Balance, GETDATE()
  FROM inserted i 
GO

CREATE TRIGGER tr_AccountsDelete ON Accounts FOR DELETE
AS
  INSERT INTO Logs (AccountID, OldSum, NewSum, ChangeDate)
  SELECT d.AccountID, d.Balance, NULL, GETDATE()
  FROM deleted d 
GO

-- Test account update
EXEC dbo.ups_DepositMoney 3, 100.00; 
GO

-- Test account insert
INSERT INTO Accounts 
VALUES (2000, 1)
GO