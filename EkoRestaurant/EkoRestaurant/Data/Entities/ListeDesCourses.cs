using System;
using System.Collections.Generic;
using EkoRestaurant.Data.Abstractions;

namespace EkoRestaurant.Data
{
    public class ListeDesCourses : BaseEntity
    {
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public DateTime? CompletionDateTime { get; set; }
        public DateTime? CreationDateTime { get; set; }

        public bool IsCompleted { get; set; } = false;
    }
}