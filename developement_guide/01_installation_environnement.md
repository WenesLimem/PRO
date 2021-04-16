# Installation de l'environnement de développement

Voici les étapes et instructions qui permettent l'installation de
l'environnement de développement.

## 1. SDK Net Core 5.0

Le projet est basé sur Blazor et le **.NET core 5.0** il est nécessaire
d'installer le SDK. Pour ce faire il existe plusieurs possibilités:

* Sur Windows, installer Visual Studio (**pas code**), l'installeur permet de
  choisir les runtimes à installer et NET CORE 5.0 en fait partie,
* Sur macOS, Visual Studio permet également d'installer le sdk,
* Sinon il faut se réferrer au [site de Micro$oft](https://dotnet.microsoft.com/download).

## 2. Azure Data Studio

Afin de voir le contenu de nos bases de données et effectuer des requêtes "à la
main", cet outil est [disponible ici](https://docs.microsoft.com/en-us/sql/azure-data-studio/download-azure-data-studio?view=sql-server-ver15).

## 3. Microsoft Sql Server 2019

Il existe là deux possibilités:

* La plus facile : installer *MSSQL* avec l'installeur Windows directement
  [disponible ici](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) en
  choisissant la version *developer*,
* Sinon en utilisant Docker [lien sur l'image docker](https://hub.docker.com/_/microsoft-mssql-server) :
  * sur macOS: installer Docker avant et le lancer, puis depuis Azure Data
    Studio, il est possible de créer "une instance locale",
  * sur Windows, se réferrer à la documentation Docker.

## 4. IDE

L'IDE de développement le mieux adapté est Visual Studio 2019. 

Si vous préférez JetBrains alors vous pouvez installer l'extension ReSharper
afin d'avoir les mêmes raccourcis clavier. Sinon Rider est ok.

## 5. Ef-Core tools

Ceci est nécessaire pour le développement :
https://docs.microsoft.com/en-us/ef/core/cli/dotnet 

Exécuter la commande dans un terminal : `dotnet tool install --global dotnet-ef`
Pour vérifier l'installation : `dotnet ef`
