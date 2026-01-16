# CARED Application Setup Guide

This guide provides the necessary steps to set up, configure, and initialize the database for the **CARED WinForms application**, which uses **.NET 6.0**, **Entity Framework Core**, **SQLite**, and **Dependency Injection (DI)**.

---

## Prerequisites

* **Visual Studio 2022** (or compatible IDE)
* Target Framework: **.NET 6.0** (or higher LTS)
* Workload: **".NET desktop development"** installed in Visual Studio.

---

## Phase 1: Project Creation and Structure

### Create Project
1.  Create a new **Windows Forms App (C#)** project targeting **.NET 6.0**.
2.  Name the project **CARED**.

### Create Directories
In the Solution Explorer, create the following four folders to organize the application layers:
* **Models** (Data entities: `Transaction`, `Procedure`, etc.)
* **Data** (Database context and configuration: `UpdatedDatabaseContext`, `ProcedureSeedData`)
* **Services** (Business logic interfaces and implementations)
* **Forms** (Your WinForms UI files)

---

## Phase 2: Install NuGet Packages

The following packages are required for EF Core and the modern Dependency Injection Host.

### Execution Steps
1.  Open **Package Manager Console (PMC)**: (Tools > NuGet Package Manager > Package Manager Console)
2.  Ensure your **CARED** project is selected in the "**Default project**" dropdown.
3.  Execute the following commands:

```powershell
# 1. EF Core SQLite Provider & Core (Data Access)
Install-Package Microsoft.EntityFrameworkCore.Sqlite
Install-Package Microsoft.EntityFrameworkCore.Tools

# 2. Dependency Injection & Hosting (Architecture)
Install-Package Microsoft.Extensions.Hosting
Install-Package Microsoft.Extensions.DependencyInjection

```
---

## Phase 3: Add Code Files
Ensure the following files are created in their respective directories (Models, Data, Services) based on the latest project structure.

## Phase 4: Database Initialization
After creating the models, context, and services, you must create the initial database migration.

### Migration Steps
1. Return to the Package Manager Console (PMC).
2. Create Initial Migration: This command generates the necessary files to create your database schema (tables, keys, defaults, and seed data).

```powershell
Add-Migration InitialSetup
```

3. Run Application: Start the application (F5). The Program.cs file will automatically execute dbContext.Database.Migrate(), applying the migration and creating the app_database.db file.