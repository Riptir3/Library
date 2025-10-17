# Library Manager

Egy C#, .NET keretrendszeren alapú, Windows Forms Application-t használó könyvtárkezelő-projekt.

## Tartalomjegyzék

- [Leírás](#leírás)  
- [Struktúra](#struktúra)
- [Panelek](#panelek)   
- [Követelmények](#követelmények)  
- [Telepítés](#telepítés)  
- [Használat](#használat)  
- [Projekt struktúra](#projekt-struktúra)  
- [Hozzájárulás](#hozzájárulás)  
- [Licenc](#licenc)

## Leírás

Ez a projekt egy C# programozási nyelven megírt Windows Forms Application, amely tartalmaz adatbázis interakciókat(EF core + SQL), loggolást, excel exportálást, illetve statisztikai diagrammok létrehozását.
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
- Az 5. oszlopban van lehetőség az író törlésére, a hozzárendelt könyvekkel együtt. (Modelekben be van állítva egy-sok kapcsolat. Amennyiben törlödik azb író, törlödnek a könyvei is).
- Az útolsó oszlop megnyomásakor, amennyiben az íróhoz tartoznak könyvek, azokan megjeleníti a Books Panelen.
<img width="962" height="628" alt="Képernyőkép 2025-10-17 102103" src="https://github.com/user-attachments/assets/39f691ec-1b4d-44bd-90e9-bc919facb175" />

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

