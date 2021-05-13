using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkoRestaurant.Data.Abstractions;

namespace EkoRestaurant.Data
{
    public class RecipeCategory : BaseEntity
    {
        public String Name { get; set; }

        public List<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}
