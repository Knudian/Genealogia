# Knudian/dotnetcore

## Installation
1. Clone the project:
```sh
git clone git@github.com:Knudian/dotnetcore.git
```
2. Create a MySql/MariaDb database.
3. Add a specific table in it :
```sql
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
)
```
4. Update your `appsettings.json` file with the good parameters.

5. Run the app
```sh
cd dotnetcore
dotnet ef database update
```

In your MySQL system, for the app database :
```sql
INSERT INTO `Ranks` (`Feminine`, `Name`) VALUES
('Empress', 'Emperor'),
('Queen', 'King'),
('Archduchess', 'Archduke'),
('Grand Princess', 'Grand Prince'),
('Princess', 'Prince'),
('Duchess', 'Duke'),
('Marchioness', 'Marquess'),
('Countess', 'Count'),
('Viscountess', 'Viscount'),
('Baroness', 'Baron'),
('Baronetess', 'Baronet'),
('Dame', 'Knight'),
('Maid', 'Gentleman');
```

Then run the app in dev mode :
```sh
dotnet watch run
```

6. Open your browser to [play with it](http://localhost:5000)