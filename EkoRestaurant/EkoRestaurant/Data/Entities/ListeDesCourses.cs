using System;
using System.Collections.Generic;
using EkoRestaurant.Data.Abstractions;

namespace EkoRestaurant.Data
{
    public class ListeDesCourses : BaseEntity
    {
        public List<Ingredient> listeDesIngredients { get; set; } = new List<Ingredient>();

        public DateTime? dateDeListe { get; set; }

        public bool isCompleted { get; set; }
    }
}