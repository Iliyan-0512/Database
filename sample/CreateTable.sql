CREATE TABLE Loans (
    LoanID INT PRIMARY KEY IDENTITY(1,1),
    BookID INT NOT NULL, -- Външен ключ към Books
    MemberID INT NOT NULL, -- Външен ключ към Members
    LoanDate DATE DEFAULT GETDATE(),
    ReturnDate DATE,
    Status NVARCHAR(20) DEFAULT 'Borrowed',
    CONSTRAINT FK_Loans_Books FOREIGN KEY (BookID) REFERENCES Books(BookID),
    CONSTRAINT FK_Loans_Members FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
);