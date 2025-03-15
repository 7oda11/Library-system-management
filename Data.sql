ALTER TABLE BorrowingRecords NOCHECK CONSTRAINT ALL;
ALTER TABLE Logs NOCHECK CONSTRAINT ALL;
ALTER TABLE Books NOCHECK CONSTRAINT ALL;
ALTER TABLE Users NOCHECK CONSTRAINT ALL;
ALTER TABLE Categories NOCHECK CONSTRAINT ALL;







DELETE FROM BorrowingRecords;
DBCC CHECKIDENT ('BorrowingRecords', RESEED, 0);

DELETE FROM Logs;
DBCC CHECKIDENT ('Logs', RESEED, 0);

DELETE FROM Books;
DBCC CHECKIDENT ('Books', RESEED, 0);

DELETE FROM Categories;
DBCC CHECKIDENT ('Categories', RESEED, 0);

DELETE FROM Users;
DBCC CHECKIDENT ('Users', RESEED, 0);






ALTER TABLE BorrowingRecords CHECK CONSTRAINT ALL;
ALTER TABLE Logs CHECK CONSTRAINT ALL;
ALTER TABLE Books CHECK CONSTRAINT ALL;
ALTER TABLE Users CHECK CONSTRAINT ALL;
ALTER TABLE Categories CHECK CONSTRAINT ALL;





-- Insert categories
INSERT INTO Categories (Name) VALUES 
('Fiction'),
('Science'),
('History'),
('Technology'),
('Philosophy');

-- Insert books
INSERT INTO Books (Title, Author, ISBN, PublishedYear, Quantity, CreatedAt, CategoryId) VALUES 
('The Great Gatsby', 'F. Scott Fitzgerald', '9780743273565', 1925, 10, GETDATE(), 1),
('A Brief History of Time', 'Stephen Hawking', '9780553380163', 1988, 8, GETDATE(), 2),
('Sapiens: A Brief History of Humankind', 'Yuval Noah Harari', '9780062316097', 2011, 6, GETDATE(), 3),
('The Art of Computer Programming', 'Donald Knuth', '9780201896831', 1968, 5, GETDATE(), 4),
('The Republic', 'Plato', '9780140455113', -380, 7, GETDATE(), 5);
