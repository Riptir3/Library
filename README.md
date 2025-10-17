# Library Manager

Egy C#, .NET keretrendszeren alapú, Windows Forms Application-t használó könyvtárkezelő-projekt.

## Tartalomjegyzék

- [Leírás](#leírás)  
- [Struktúra](#struktúra)
- [Panelek](#panelek)   
- [Követelmények](#követelmények)  
- [Telepítés](#telepítés)  
- [Használat](#használat)  

## Leírás

Ez a projekt egy C# programozási nyelven megírt Windows Forms Application, amely tartalmaz adatbázis interakciókat(EF core + SQL), loggolást, Excel-exportálást, illetve statisztikai diagramok létrehozását.
Rétegezett architektúrát és konstruktoron keresztüli hivatkozásátadást valósít meg generikus módszerekkel.
A cél, hogy modulárisan lehessen használni különféle .NET alkalmazásokban.

## Struktúra

```
Library/
├── Controllers/ -> Vezérlő osztályok, az adatbázisba való mentést segítik elő. 
├── DTOs/ -> Data Transfer Object osztályok, csökkentik az erőforrás igényt.
├── Data/ -> Adatbázis interakciók Interfacei, illetve osztályai. 
├── DatabaseConfig/ -> Adatbázis konfiguráció.
├── Enums/ -> Enumerációk.
├── Excel/ -> Excel-kezelő osztály.
├── Log/ -> Logger osztály.
├── Migrations/ -> EF migrációk
├── Models/ -> Entitás modellek
├── SpecialRepositories/ -> Speciális adattároló / repo osztályok
├── Program.cs
├── Library.csproj
└── Library.sln
```
## Panelek

### Welcome Panel
- Üdvözlő oldal.

### Authors Panel
- Ezen az oldalon történik az írók kezelése. (teljes CRUD)
- Datagridviewban jelennek meg az adatbázisból lekért adatok.
<img width="970" height="633" alt="Képernyőkép 2025-10-17 102031" src="https://github.com/user-attachments/assets/3a09cd09-e072-4d9e-bafc-20607b600280" />

- A 4. oszlop megnyomásakor megnyílik egy új ablak, ahol van lehetőség a kiválasztott író adatainak modósítására.
- Az 5. oszlopban van lehetőség az író törlésére, a hozzárendelt könyvekkel együtt. (Modelekben be van állítva egy-sok kapcsolat. Amennyiben törlődik az író, törlődnek a könyvei is.).
- Az útolsó oszlop megnyomásakor, amennyiben az íróhoz tartoznak könyvek, azokan megjeleníti a `Books Panelen`.

<img width="962" height="628" alt="Képernyőkép 2025-10-17 102103" src="https://github.com/user-attachments/assets/39f691ec-1b4d-44bd-90e9-bc919facb175" />

- Van lehetőség keresésre, illetve jobb felső ikonnal exportálni tudjuk az állományt excel fileba.

### Books Panel
- Ezen az oldalon történik a könyvek kezelése. (teljes CRUD).
- Ugyanazokat a funkciókat tartalmazza, mint az `Authors Panel`.

### Statisztika Panel
- Ezen a Panelen található 2 chart
  - Egy PieChart, amely a kiválasztott író könyveinek eloszlását mutatja könyv típusonként.
  - A második egy BarChart, amely az összes író könyveinek a számát viszonyítja egymáshoz.
<img width="958" height="624" alt="Képernyőkép 2025-10-17 102208" src="https://github.com/user-attachments/assets/d44447ee-4341-4bf0-beae-876b1642ac13" />

## Követelmények

- .NET Core / .NET 6+. 
- C#.
- EF core.
- Adatbázis (pl. SQL Server, SQLite, stb.).
- Excel kezeléshez szükséges csomag (ClosedXML).
- Chartokhoz ScottPlot.

## Technológiák

- **Programozási nyelv:** C#.
- **Keret:** .NET 6 / Windows Forms.
- **Adatbázis:** Entity Framework Core + SQL Server.
- **Diagramok:** ScottPlot.
- **Excel export:** ClosedXML.
- **Loggolás:** Egyedi Logger osztály.

## Telepítés

1. Clone-olás:
    ```bash
    git clone https://github.com/Riptir3/Library.git
    ```
2. Belépés a könyvtárba:
    ```bash
    cd Library
    ```
3. Restaurálás és build:
    ```bash
    dotnet restore
    dotnet build
    ```

## Használat

1. Konfiguráld az adatbázist (pl. `AppDbContext`, connection string)  
2. Használd a modelleket, DTO-kat, repozitóriumokat és vezérlőket az alkalmazásodban  
3. Ha szükséges, futtasd a migrációkat:
    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
4. Indítsd el az alkalmazást:
   ```bash
   dotnet run ```

## Kapcsolat

Fejlesztő: **Riptir3 (Bence)**  
GitHub: [github.com/Riptir3](https://github.com/Riptir3)
