CREATE TABLE Loans (
    LoanID INT PRIMARY KEY IDENTITY(1,1),
    BookID INT NOT NULL,
    MemberID INT NOT NULL,
    LoanDate DATE DEFAULT GETDATE(),
    ReturnDate DATE,
    Status NVARCHAR(20) DEFAULT 'Borrowed',
    CONSTRAINT FK_Loans_Books FOREIGN KEY (BookID) REFERENCES Books(BookID),
    CONSTRAINT FK_Loans_Members FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
);
GO

-- Добавяне на данни в таблицата Books
INSERT INTO Books (Title, Author, Genre, PublishYear, AvailableCopies)
VALUES
('Atomic Habits', 'James Clear', 'Self-help', 2018, 10),
('Rich Dad Poor Dad', 'Robert Kiyosaki', 'Finance', 1997, 7),
('World War II: A Complete History', 'Martin Gilbert', 'History', 1989, 5),
('The First World War', 'John Keegan', 'History', 1998, 4),
('English Language Workbook', 'John Smith', 'Education', 2022, 15);
GO

-- Добавяне на данни в таблицата Members
INSERT INTO Members (FirstName, LastName, Email, PhoneNumber, MembershipDate)
VALUES 
('John', 'Doe', 'john.doe@example.com', '123456789', GETDATE()),
('Jane', 'Smith', 'jane.smith@example.com', '987654321', GETDATE());
GO

-- Добавяне на данни в таблицата Loans
INSERT INTO Loans (BookID, MemberID, LoanDate, ReturnDate, Status)
VALUES 
(1, 1, GETDATE(), NULL, 'Borrowed'),
(2, 2, GETDATE(), DATEADD(DAY, 7, GETDATE()), 'Returned');
GO