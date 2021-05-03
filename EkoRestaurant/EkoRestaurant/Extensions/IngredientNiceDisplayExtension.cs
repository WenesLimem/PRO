using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkoRestaurant.Data;

namespace EkoRestaurant.Extensions
{
    public static class IngredientNiceDisplayExtension
    {
        public static string GetProducerName(this Ingredient ingredient)
        {
            return ingredient.Producer ?? " - ";
        }

        public static string GetCategoryName(this Ingredient ingredient)
        {
            return ingredient.Category != null ? ingredient.Category.Name : "N / A";
        }


        public static string BooleanToFrench(this bool booleanValue)
        {
            return booleanValue ? "Oui" : "Non";
        }
    }
}
