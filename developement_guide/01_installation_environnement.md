# Installation de l'environnement de développement



## 1. SDK Net Core 5.0

Le projet est basé sur blazor et le **.NET core 5.0** il est nécessaire d'installer le sdk. Pour ce faire il existe plusieurs possibilitées:

* Sur windows, installer visual studio (**pas code**), l'installeur permet de choisir les runtimes a installer et NET CORE 5.0 en fait partie.

* Sur mac, visual studio permet également d'installer le sdk 
* sinon il faut se referrer au [site microsoft](https://dotnet.microsoft.com/download) 

## 2. Azure data studio

Afin de voir le contenu de nos base de données et effectuer des requêtes "à la main" cet outil est [disponible ici](https://docs.microsoft.com/en-us/sql/azure-data-studio/download-azure-data-studio?view=sql-server-ver15)

## 3. Microsoft Sql Server 2019

Il existe là deux possibilitées:

* La plus facile installer *MSSQL* avec l'installeur windows directement [disponible ici](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) en choissisant la version developer
* Sinon en utilisant docker [lien sur l'image docker](https://hub.docker.com/_/microsoft-mssql-server)
  * sur mac: installer docker avant et le lancer, puis depuis azure data studio il est possible de créer "une instance locale"
  * sur windows, se referrer à la documentation docker



## 4. IDE

L'ide de developpement le mieux adapté est Visual Studio 2019. 

Si vous préferrez Jetbrains alors vous pouvez installer l'extension ReSharper afin d'avoir les mêmes raccourcis clavier. Sinon Rider est ok.

## 5. outil pour uml

*A completer*