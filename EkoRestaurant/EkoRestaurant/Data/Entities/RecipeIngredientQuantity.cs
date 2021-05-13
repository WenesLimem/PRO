using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkoRestaurant.Data.Abstractions;

namespace EkoRestaurant.Data
{
    public class RecipeIngredientQuantity : BaseEntity
    { 
        public Ingredient Ingredient { get; set; }
        public Recipe Recipe { get; set; }
        public int Quantity { get; set; }
    }
}
