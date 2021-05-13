using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkoRestaurant.Data;
using EkoRestaurant.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace EkoRestaurant.Services
{
    public class RecipesService : BaseDataService<Recipe>
    {
        public RecipesService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }


        public Recipe GetByIdWithIngredients(int id)
        {
            return _dbContext.Set<Recipe>()
                .Include(x => x.IngredientQuantities)
                .ThenInclude(y => y.Ingredient)
                .FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Recipe> FilterWithIngredients()
        {
            return _dbContext.Set<Recipe>()
                .Include(x => x.IngredientQuantities)
                .ThenInclude(y => y.Ingredient);
        }


        public IEnumerable<Recipe> FilterWithIngredients(Func<Recipe, bool> predicate)
        {
            return _dbContext.Set<Recipe>()
                .Include(x => x.IngredientQuantities)
                .ThenInclude(y => y.Ingredient)
                .Where(predicate);
        }
    }
}
