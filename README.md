# 📚 Library Management System

🚀 A powerful, user-friendly desktop application for managing library books, members, and borrowing records.

## 🔹 Overview
The **Library Management System** is a **.NET WinForms** desktop application built using **C#**, **Entity Framework Core**, and **SQL Server**. It provides an efficient way to manage books, track borrowing records, and maintain a structured library system for both librarians and members.

## 🔹 Features
✅ **User Management** – Admin can add, update, delete, and manage librarians & members.  
✅ **Book Management** – Add, update, delete, and search books by title, author, or category.  
✅ **Member Management** – Manage members with details like name, email, and phone number.  
✅ **Borrowing & Return System** – Track book availability and manage due dates.  
✅ **Reports & Logging** – Generate reports for borrowed books, available books, and overdue books.  
✅ **Authentication** – Secure login system with password protection.  
✅ **(Optional) QR Code Scanning** – Quick book entry via QR code.  
✅ **(Optional) Email Notifications** – Notify users of upcoming due dates.  

---

## 🔹 Technology Stack
- **Programming Language:** C#
- **Framework:** .NET (WinForms)
- **Database:** SQL Server
- **ORM:** Entity Framework Core, Dapper
- **UI Components:** WinForms

---

## 🔹 Database Schema & Relations
The system follows a **Code-First Approach** using Entity Framework Core. Below are the key tables and their relationships:

### 🗃️ **Tables & Relationships**
1. **Users**
   - `Id` (Primary Key)
   - `Username`
   - `PasswordHash`
   - `Role` (Librarian / Member)
   - `Email`
   - `PhoneNumber`
   - `CreatedAt`
   - 📌 **One-to-Many:** A librarian can manage multiple books and members.

2. **Books**
   - `Id` (Primary Key)
   - `Title`
   - `Author`
   - `ISBN`
   - `Category`
   - `Quantity`
   - `PublishedYear`
   - 📌 **One-to-Many:** One book can have multiple borrow records.

3. **Members**
   - `Id` (Primary Key)
   - `Name`
   - `Email`
   - `Phone`
   - `MembershipType` (Student / Faculty / Other)
   - 📌 **One-to-Many:** A member can borrow multiple books.

4. **BorrowingRecords**
   - `Id` (Primary Key)
   - `UserId` (Foreign Key from Users)
   - `BookId` (Foreign Key from Books)
   - `BorrowDate`
   - `DueDate`
   - `ReturnDate`
   - 📌 **Many-to-One:** Many borrowing records relate to one user and one book.

5. **Logs**
   - `Id` (Primary Key)
   - `Action`
   - `Timestamp`
   - `PerformedBy` (UserId)
   - 📌 **Tracks actions** like borrowing, returning books, and user management.

---

## 🔹 Installation & Setup

### 1️⃣ Clone the Repository
```sh
git clone https://github.com/YourUsername/LibraryManagementSystem.git
cd LibraryManagementSystem
