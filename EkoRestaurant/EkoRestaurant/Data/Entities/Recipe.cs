using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkoRestaurant.Data.Abstractions;

namespace EkoRestaurant.Data
{
    public class Recipe : BaseEntity
    {
        public String Name { get; set; }
        public String Description { get; set; }

        public double PreparationTimeMinutes { get; set; }
        public double Price { get; set; }
    }
}
