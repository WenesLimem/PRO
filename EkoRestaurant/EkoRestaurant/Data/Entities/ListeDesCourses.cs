using System;
using System.Collections.Generic;
using EkoRestaurant.Data.Abstractions;

namespace EkoRestaurant.Data
{
    public class ListeDesCourses : BaseEntity

    {
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public DateTime? ListDate { get; set; }
    }
}