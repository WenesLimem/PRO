# Guide pour débuter avec EF Core

EF Core (Entity Framework Core) est une version légère, extensible, open source
et multiplateforme de la technologie d'accès aux données Entity Framework. EF
Core peut servir d'ORM afin de gérer plusieurs technologies de base de données.

## Comment changer le modèle de la base de données

Lors du changement, ajout, suppression d'une entité dans le code, la base de
données doit être mise à jour.

Pour ça, il existe deux commandes :

* une pour la console du packet manager (=PMC),
* une pour le terminal standard.

C'est la même chose lorsque les modifications des collègues instaurent des
changements sur les entités.

### Le processus lorsque l'on veut faire un changement est:

1. Faire un changement dans le code sur l'entité,
2. Ajouter une migration,
3. Appliquer une migration,
4. Tester.

### Le processus lorsque l'on reçoit un changement:

(souvent on a juste des erreurs liées à SQL)

1. Voir que ca ne marche pas,
2. Appliquer la migration,
3. Voir que ca marche.

<table>
  <thead>
    <tr>
      <td align="left">
        :information_source: Information
      </td>
    </tr>
  </thead>

  <tbody>
    <tr>
      <td>
        <ul>
          <li>Si vraiment on est bloqué, on peut supprimer notre base de données et recommencer depuis une vide.</li>
        </ul>
      </td>
    </tr>
  </tbody>
</table>

| Quoi                                             | PMC                              | Dot net cli (dans le dossier du `.csproj`)    |
| ------------------------------------------------ | -------------------------------- | --------------------------------------------- |
| Ajout de migrations dans le dossier *Migrations* | `add-migration MyFirstMigration` | `dotnet ef migrations add MyFirstMigration`   |
| Application des migrations                       | `Update-Database`                | `dotnet ef database update`                   |

## Implémenter les services de données

Les entité doivent dériver de la classe abstraite `BaseEntity`

Les entités doivent être présentes dans le contexte `ApplicationDbContext` sous
la forme de :

```csharp
public DbSet<TEntity> TEntities { get; set; }
```

Ensuite un service de donnée doit être fait sur la base de l'exemple suivant :

```csharp
namespace EkoRestaurant.Services
{
    public class IngredientsService : BaseDataService<Ingredient>
    {
        public IngredientsService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
```

Puis il faut l'enregistrer dans le `Startup.cs` dans la fonction 
`public void ConfigureServices(IServiceCollection services)` afin de pouvoir y 
accéder plus tard grâce à l'injection de dépendances.

Ceci nous permet d'accéder de manière générique aux données au moyen de ces
méthodes :

```csharp
namespace EkoRestaurant.Services.Abstractions
{
    interface IDataService<TEntity> where TEntity : BaseEntity
    {
        TEntity Create(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int id);
        TEntity Edit(TEntity entity);

        TEntity GetById(int id);
        IEnumerable<TEntity> Filter();
        IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate);
        void SaveChanges();
    }
}
```

## Comment utiliser les services de données ?

Dans la page utiliser le tag `@inject IngredientsService IngredientsService`.

## Edition

Lors de l'édition des objets il est nécessaire d'appeler `SaveChanges()` afin
d'envoyer les changements sur la base de données.

Pour supprimer: 

```csharp
IngredientCategoriesService.Delete(SelectedCategory.Id);
IngredientCategoriesService.SaveChanges();
```

Pour ajouter:

```
IngredientsService.Create(res);
IngredientsService.SaveChanges();
```

Pour modifier utiliser de la même manière ` TEntity Edit(TEntity entity)` suivi
de `SaveChanges()`.

## Lecture

Les méthode `TEntity GetById(int id)`, `IEnumerable<TEntity> Filter()`,
`IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate)` sont à disposition.
