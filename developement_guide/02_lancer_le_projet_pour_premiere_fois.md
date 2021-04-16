# Lancer le projet pour la première fois

Ceci vous permet de lancer le projet pour la première fois afin de pouvoir le
tester.

## Installation des dépendances `nuget`

Le projet a des dépendances externes, il a donc besoin de récupérer celles-ci.

Si cela ne se fait pas automatiquement, voir
[ceci](https://docs.microsoft.com/en-us/nuget/consume-packages/package-restore)
(la commande à executer est `nuget restore MySolution.sln`).

## Paramètres d'accès à la base de données

Si vous avez installé Microsoft SQL Server de manière native sur Windows vous
êtes déjà prêt. Sinon avec Docker il faudra remplacer la *connection string*
dans le fichier `appsettings.json` de telle manière :

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=127.0.0.1,<PORT>;Database=ekoDB;User Id=sa;password=<PASSWORD>;Trusted_Connection=False;MultipleActiveResultSets=true;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}
```

## Création de la base de données

Soit depuis SQL Server Management Studio, soit depuis Azure Data Studio, vous
pouvez créer une base de données vide appelée "ekoDB".

## Application des migrations EF-Core

Pour créer les tables dans notre base de données, il faut :

* soit depuis "Visual Studio > Tools > nuget... > Packet manager Console"
  exécuter la commande `Update-Database`,
* Sinon depuis un terminal dans le dossier du fichier `.csproj` exécuter la
  commande `dotnet ef database update`.

## C'est parti !

Maintenant vous devriez voir le projet lorsque vous lancez l'exécution depuis
votre IDE.
