# 📚 Library Management System (C# + SQL)

A fully functional **Library Management System** built with **C# (.NET)** for backend logic and **SQL** for database management.  
This project simulates real-world library operations, from managing members and books to handling fines, reservations, and stock records.  

---

## ✨ Features

### 👤 Member Management
- Add and search members  
- View member personal data  
- Track borrowing history, lost/damaged books, reservations, and fine payments  

### 📚 Book Management
- Add/search books  
- Check availability and current holder  
- Track lost/damaged books and history  

### 🔄 Borrow & Return
- Auto-fill details by Member ID / Book ID  
- Smart handover with member lookup  
- Overdue books highlighted in **red** with fine calculation  
- Options to accept fines, record payments, or waive fines (with reason)  

### 📝 Reservation System
- Reserve books when unavailable  
- Automatic email notification to the next member once the book is returned  

### 💰 Fine Management
- Auto-calculated fines for overdue books  
- Record payments and exceptions  

### 📦 Stock & Records
- Track book orders, losses, damages  
- Keep records of members involved in book-related issues  

---

## 🛠️ Tech Stack
- **C# (.NET)** – Backend logic & business workflows  
- **SQL** – Database management and queries  
- **WinForms / WPF (if applicable)** – User interface  
- **SMTP / Email Integration** – Reservation notifications  

---

## 🚀 Getting Started

### Prerequisites
- Install [Visual Studio](https://visualstudio.microsoft.com/) with `.NET desktop development` workload  
- Install [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or SQL Express)  
- Basic knowledge of C# and SQL  

### Steps
1. Clone this repository

tps://github.com/HiruniYasoda/Library-management-system.git
