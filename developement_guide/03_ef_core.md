# Guide pour débuter avec EF Core



## C'est quoi ? 

Un ORM fait par Microsoft capable de gérer plusieurs technologie de base de données.

## Comment changer le modèle de la base de donnée

Lors du changement, ajout, suppression d'une entité dans le code, la base de donnée doit être mise a jour.

Pour ça, il existe deux commandes, une pour la console du packet manager (=PMC) une pour le terminal standard.

C'est la même chose lorsque les modifications des collègues instaures des changement sur les entités.

#### le processus lorsque l'on veut faire un changement est:

1. Faire un changement dans le code sur l'entité
2. Ajouter une migration
3. Appliquer une migration
4. Tester

#### le processus lorsque l'on recois un changement:

(souvent on a juste des erreurs liée à sql)

1. Voir que ca ne marche pas
2. Appliquer la migration
3. Voir que ca marche

! Si vraiment on est bloqué, on peut supprimer notre base de donnée et recommencer depuis une vide



| Quoi                                           | PMC                              | Dot net cli                                 |
| ---------------------------------------------- | -------------------------------- | ------------------------------------------- |
| Ajout de migrations dans le dossier migrations | `add-migration MyFirstMigration` | `dotnet ef migrations add MyFirstMigration` |
| Application des migrations                     | `Update-Database`                | `dotnet ef database update`                 |



## Implémenter les services de données

Les entité doivent dériver de la classe abstraite `BaseEntity`

Les entités doivent être présentes dans le context `ApplicationDbContext` sous la forme de 

```csharp
public DbSet<TEntity> TEntities { get; set; }
```

Ensuite un service de donnée doit être fait sur la base de l'exemple suivant:

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

Puis il faut l'enregistrer dans le `Startup.cs` dans la fonction `public void ConfigureServices(IServiceCollection services)` afin de pouvoir y acceder plus tard grâce à l'injection de dépendences.

Ceci nous permet d'avoir une facon générique l'accès au donnée au moyen de ces méthodes:

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

Dans la page utiliser le tag `@inject IngredientsService IngredientsService`

## Edition

Lors de l'édition des objets il est necessaire d'appeler `SaveChanges()`afin d'envoyer les changements sur la base de donnée.

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

Pour modifier utiliser de la même manière ` TEntity Edit(TEntity entity)` suivi de `SaveChanges()`

## Lecture

Les méthode `TEntity GetById(int id)`, `IEnumerable<TEntity> Filter()`, `IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate)` sont à disposition.

