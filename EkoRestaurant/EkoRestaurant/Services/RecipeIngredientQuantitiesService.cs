using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkoRestaurant.Data;
using EkoRestaurant.Services.Abstractions;

namespace EkoRestaurant.Services
{
    public class RecipeIngredientQuantitiesService : BaseDataService<RecipeIngredientQuantity>
    {
        public RecipeIngredientQuantitiesService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
