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

        public static double GetIngredientPrice(this Recipe recipe)
        {
            double costs = 0;
            foreach (RecipeIngredientQuantity ingredientQuantity in recipe.IngredientQuantities)
            {
                costs += ingredientQuantity.Quantity * ingredientQuantity.Ingredient.UnitPrice;
            }

            return costs;
        }

        public static bool CanBeProduced(this Recipe recipe)
        {
            foreach (RecipeIngredientQuantity ingredientQuantity in recipe.IngredientQuantities)
            {
                if (ingredientQuantity.Quantity > ingredientQuantity.Ingredient.UnitInStock)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsVeganFriendly(this Recipe recipe)
        {
            foreach (RecipeIngredientQuantity ingredientQuantity in recipe.IngredientQuantities)
            {
                if (ingredientQuantity.Ingredient.IsVegan == false)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsArachidesFree(this Recipe recipe)
        {
            foreach (RecipeIngredientQuantity ingredientQuantity in recipe.IngredientQuantities)
            {
                if (ingredientQuantity.Ingredient.ContainsArachides == false)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsLactoseFree(this Recipe recipe)
        {
            foreach (RecipeIngredientQuantity ingredientQuantity in recipe.IngredientQuantities)
            {
                if (ingredientQuantity.Ingredient.ContainsLactose == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
