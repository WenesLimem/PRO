using System;
using EkoRestaurant.Data.Abstractions;

namespace EkoRestaurant.Data
{
    public class Ingredient : BaseEntity
    {
        public String Name { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public double UnitPrice { get; set; }

        public String Producer { get; set; }

        public int UnitInStock { get; set; }
        public int UnitAtStart { get; set; }
        
        public String UnitSuffix { get; set; }

        public int? CategoryId { get; set; }
        public IngredientCategory? Category { get; set; }

        public bool IsVegan { get; set; } = false;

        public bool ContainsArachides { get; set; } = false;
        public bool ContainsLactose { get; set; } = false;
    }
}