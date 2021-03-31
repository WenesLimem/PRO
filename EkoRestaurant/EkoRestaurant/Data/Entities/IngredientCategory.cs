using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkoRestaurant.Data
{
    public class IngredientCategory : BaseEntity
    {
        public String Name { get; set; }

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}
