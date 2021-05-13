using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkoRestaurant.Data;

namespace EkoRestaurant.Extensions
{
    public static class RecipeNiceDisplayExtension
    {
        public static string GetCategoryName(this Recipe recipe)
        {
            return recipe.Category != null ? recipe.Category.Name : "N / A";
        }
    }
}
