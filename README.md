# BankingApp

We will look at using Abstraction, Encapsulation, Inheritance and Polymorphism to design a simple banking application that will allow you to manage client accounts.

Definition of a bank account:
1) It has a 10-digit number that uniquely identifies the bank account.
2) It has a string that stores the name or names of the owners.
3) The balance can be retrieved.
4) The account needs to journal all transactions to the account via deposits / withdrawals
4.1) It accepts deposits.
4.2) It accepts withdrawals.
5) The initial balance must be positive.
6) Withdrawals cannot result in a negative balance.

Definition of a transaction
1) It has an amount
2) It has a date and time of when the transaction happened
3) It has a note to provide transaction details

USE TDD (Test Driven Design)  
- Each issue MUST have its own branch created from MASTER with a PULL REQUEST once the feature is completed
- Branched must be vreated in the format "users\%username%\%category%-%entity%-%action%" i.e. users\martiini624\data-bankaccount-deposits
  - %username% your username
  - %category% the category i.e.  DATA, BROKERS, FOUNDATIONS etc
  - %entity% the thing that you are working on
  - %action% the function/ work you are doing
- Each step should start with a failing test followed with a COMMIT to show the failing test i.e.  ShouldAcceptDepostit -> FAIL
- Each step should end with a COMMIT to show the passing test once logic were added i.e.  ShouldAcceptDepostit -> PASS


PART 1
STEPS
1) Start by creating the basics of a class BankAccount that defines the behavior.
2) Create a new object of the BankAccount class as define above
2.1) Happy path of just opening a bank account  
2.2) Logic to prevent opening account with a negative balance
3) Add the logic to compute the balance
4) Add the logic to make a deposit
4.1) Happy path to just make a deposit
4.2) Logic to prevent a deposit of any amount smaller or equal to zero.
5) Add the logic to make a withdrawal
5.1) Happy path to just make a withdrawal
5.2) Logic to prevent a withdrawal of any amount smaller or equal to zero.
6) Add logic to retrieve account history
Optional tasks
7) Show transaction history where the notes contains a specific value
8) Show transaction history where the value is greater or equal to x
9) Show transaction history where the value is greater or equal to x but smaller or equal to y
10) Show transaction history where the notes contains a value x, where the value is greater or equal to y and smaller or equal to z




PART 2
The bank has grown and is now also offering different types of accounts.  Change the existing application to also offer the following accounts:

1) An interest earning account:
- Will get a credit of 2% of the month-ending-balance.

2) A line of credit:
- Can have a negative balance, but not be greater in absolute value than the credit limit.
- Will incur an interest charge each month where the end of month balance isn't 0.
- Will incur a fee on each withdrawal that goes over the credit limit.

3) A gift card account:
- Can be refilled with a specified amount once each month, on the last day of the month.

All three of these account types have an action that takes places at the end of each month. However, each account type does different tasks. Use polymorphism to implement this code by applying an PerformEndOfMonthTransaction method to BankAccount

Add unit tests to show that all previous and additional functionality is working.
