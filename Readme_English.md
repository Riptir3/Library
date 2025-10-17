# Library Manager
A **C# .NET-based Windows Forms Application** for managing authors, books, and related data through a layered architecture.

---

## Table of Contents

- [Description](#description)  
- [Structure](#structure)  
- [Panels](#panels)  
- [Requirements](#requirements)  
- [Technologies](#technologies)  
- [Installation](#installation)  
- [Usage](#usage)  
- [Development Ideas](#development-ideas)  
- [Contact](#contact)

---

## Description

**Library Manager** is a C# project built with **Windows Forms** and **Entity Framework Core**, providing database interactions, logging, Excel export, and data visualization via charts.  
It implements a **layered architecture** and uses **constructor-based dependency passing** with **generic repository patterns**.  
The goal is to make the system **modular and reusable** across different .NET applications.

---

## Structure

```
Library/
├── Controllers/ -> Controller classes managing database operations.
├── DTOs/ -> Data Transfer Objects to improve performance and abstraction.
├── Data/ -> Database interfaces and repositories.
├── DatabaseConfig/ -> Database configuration files.
├── Enums/ -> Enumerations.
├── Excel/ -> Excel export and management utilities.
├── Log/ -> Custom logger class.
├── Migrations/ -> EF Core migrations.
├── Models/ -> Entity models.
├── SpecialRepositories/ -> Specialized repository implementations.
├── Program.cs
├── Library.csproj
└── Library.sln
```
## Panels

### Welcome panel
- Displays a welcome screen at startup.

### Authors panel
- Handles CRUD operations for authors.
- Displays authors in a `DataGridView` fetched from the database.
  
<img width="970" height="633" alt="Képernyőkép 2025-10-17 102031" src="https://github.com/user-attachments/assets/3a09cd09-e072-4d9e-bafc-20607b600280" />

- The 4th column opens an edit window for updating data.
- The 5th column allows deleting authors (and their associated books via one-to-many relationship).
- The last column shows all books for the selected author in the Books Panel.

<img width="962" height="628" alt="Képernyőkép 2025-10-17 102103" src="https://github.com/user-attachments/assets/39f691ec-1b4d-44bd-90e9-bc919facb175" />

- Lehetőség van keresésre, illetve a jobb felső ikon segítségével az adatok Excel-fájlba exportálhatók.

### Books panel
- A könyvek kezelése (teljes CRUD).
- Ugyanazokat a funkciókat tartalmazza, mint az `Authors panel`.

### Statisztika panel
- Két diagramot jelenít meg:
  - Egy **kördiagram** (PieChart), amely a kiválasztott író könyveinek eloszlását mutatja műfajonként.  
  - Egy **oszlopdiagram** (BarChart), amely az összes író könyveinek számát hasonlítja össze.

<img width="958" height="624" alt="Képernyőkép 2025-10-17 102208" src="https://github.com/user-attachments/assets/d44447ee-4341-4bf0-beae-876b1642ac13" />

## Requirements

- .NET 6+
- C#
- Entity Framework Core
- SQL database (e.g., SQL Server or SQLite)
- ClosedXML (for Excel export)
- ScottPlot (for chart visualization)

## Technologies

- **Language:** C#.
- **Framework:** .NET 6 / Windows Forms.
- **Database:** Entity Framework Core + SQL Server.
- **Charts:** ScottPlot.
- **Excel Export:** ClosedXML.
- **Logging:** Custom Logger Class.

## Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/Riptir3/Library.git
    ```
2. Enter the project directory:
    ```bash
    cd Library
    ```
3. Restore dependencies and build the project:
    ```bash
    dotnet restore
    dotnet build
    ```

## Usage

1. Configure your database connection ( `AppDbContext`, connection string). 
2. Use models, DTOs, repositories, and controllers within your application.
3. (Optional) Apply EF migrations:
    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
4. Run the application:
   ```bash
   dotnet run ```

## Development Ideas

1. Convert to Async/Await.
2. Implement Full Dependency Injection (DI).
3. Add Unit and Integration Tests.
4. Modernize UI.

## Contact

Developer: **Riptir3 (Bence)**  
GitHub: [github.com/Riptir3](https://github.com/Riptir3)
