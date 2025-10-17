# Library Manager

Egy C#, .NET keretrendszeren alapú, Windows Forms Application-t használó könyvtárkezelő-projekt.

## Tartalomjegyzék

- [Leírás](#leírás)  
- [Struktúra](#struktúra)  
- [Követelmények](#követelmények)  
- [Telepítés](#telepítés)  
- [Használat](#használat)  
- [Projekt struktúra](#projekt-struktúra)  
- [Hozzájárulás](#hozzájárulás)  
- [Licenc](#licenc)

## Leírás

Ez a projekt egy C# programozási nyelven megírt Windows Forms Application, amely tartalmaz vezérlőket, adatszerkezeteket (DTO-k), modelleket, migrációkat és Excel-rel kapcsolatos funkcionalitást.  
A cél, hogy modulárisan lehessen használni különféle .NET alkalmazásokban.

## Struktúra

Library/
├── Controllers/ -> Vezérlő osztályok, az adatbázisba való mentést segítik elő. 
├── DTOs/ -> Data Transfer Object osztályok, csökkentik az erőforrás igényt.
├── Data/ -> Adatbázis interakciók Interfacei, illetve osztályai.
├── DatabaseConfig/ -> Adatbázis konfiguráció.
├── Enums/ -> Enumerációk.
├── Excel/ -> Excel-kezelő osztály.
├── Migrations/ -> EF migrációk
├── Models/ -> Entitás modellek
├── SpecialRepositories/ -> Speciális adattároló / repo osztályok
├── Program.cs
├── Library.csproj
└── Library.sln

## Követelmények

- .NET Core / .NET 5+ (vagy amely verzióval a projekt építve van)  
- C#  
- Adatbázis (pl. SQL Server, SQLite, stb.)  
- Ha Excel funkciókat használsz: valamilyen Excel kezeléshez szükséges csomag (pl. EPPlus, ClosedXML vagy hasonló)

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

1. Add referenciaként egy másik .NET vagy ASP.NET projektben  
2. Konfiguráld az adatbázist (pl. `DbContext`, connection string)  
3. Használd a modelleket, DTO-kat, repozitóriumokat és vezérlőket az alkalmazásodban  
4. Ha szükséges, futtasd a migrációkat:
    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```

5. Excel export / import használata, ha beépítetted az Excel logikát

## Projekt struktúra

