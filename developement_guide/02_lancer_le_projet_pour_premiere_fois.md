# Lancer le projet pour la première fois

Ceci vous permet de lancer le projet pour la première fois afin de pouvoir le tester.

## Installation des dépendances nuget

Le projet a des dépendances externe, il a donc besoin de récuperer celle-ci.

Si cela ne se fait pas automatiquement, voir [ceci](https://docs.microsoft.com/en-us/nuget/consume-packages/package-restore) (la commande é executer est `nuget restore MySolution.sln`)

## Paramètres d'accès à la base de donnée

Si vous avez installé Microsoft Sql Server de manière native sur Windows vous êtes déjà prêt.
Sinon avec docker il faudra remplacer la "connection string" dans le fichier `appsettings.json` de telle manière:

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

## Création de la base de donnée

Soit depuis Sql server management studio, soit depuis azure data studio, vous pouvez créer une base de donnée vide appelée "ekoDB"

## Application des migrations EF-Core

Pour créer les table dans notre base de données. 

Il faut

* soit depuis "Visual studio > Tools > nuget... > Packet manager Console" executer la commande `Update-Database`
* Sinon depuis un terminal dans le dossier du fichier `.csproj` executer la commande `dotnet ef database update`



## C'est parti !

Maintenant vous devriez voir le projet lorsque vous lancer l'exécution depuis votre IDE

