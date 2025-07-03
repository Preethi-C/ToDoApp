# ToDo List App - ASP.NET MVC

A simple ToDo List CRUD application built using ASP.NET MVC. This project was developed as part of my learning journey to strengthen my understanding of C#, MVC architecture, and database operations.

---

## Project Overview

This is a beginner-level web application that allows users to manage a list of tasks using full CRUD operations — Create, Read, Update, and Delete. It demonstrates key concepts in ASP.NET MVC and Entity Framework Core.

---

## Tech Stack

- Language: C#
- Framework: ASP.NET MVC
- Front-end: HTML, Bootstrap
- Database: SQL Server
- ORM: Entity Framework Core (Code-First)
- IDE: Visual Studio 2022

---

## Features

- Add a new task  
- Edit an existing task  
- Mark tasks as Completed or Pending  
- Delete a task  
- Display task status with color indicators (green for Completed, red/orange for Pending)  
- Server-side form validation  

---

## How to Run the Project

> Note: This application was developed using Visual Studio 2022 and tested with SQL Server.

### Prerequisites

- Visual Studio 2022 or later
- .NET SDK installed
- SQL Server or SQL Server Express

### Steps

1. Clone the repository:

git clone https://github.com/Preethi-C/STUDY.CRUD-EmployeeManagementSystem.git

2. Open the solution in Visual Studio (`.sln` file).

3. Restore NuGet packages:
- Right-click the solution and select **Restore NuGet Packages**

4. Apply Entity Framework Core migrations:
- Open the **Package Manager Console** and run:
  ```
  Update-Database
  ```

5. Run the application:
- Press `F5` or click **Start** in Visual Studio

---

## Database

- This project uses **Entity Framework Core with Code-First approach**
- No manual SQL scripts are required; the schema is auto-generated using migrations

---

## Learning Goals

This project was created for educational purposes, specifically to practice:

- Building applications with ASP.NET MVC
- Using Entity Framework Core for data access
- Performing CRUD operations
- Working with model validation and conditional UI logic

---

## Author

**Preethi C**  
Aspiring full stack developer focused on C# and .NET technologies.

---

## License

This project is free to use for personal and educational purposes.
