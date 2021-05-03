using System;
using System.Linq;
using EkoRestaurant.Data;
using EkoRestaurant.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace EkoRestaurant.Services
{
    public class ListeDesCoursesServices: BaseDataService<ListeDesCourses>
    {
        public ListeDesCoursesServices(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public void GetData()
        {
            


        }
        public void AddIngredientToList(Ingredient ing)
        {
            var currlist = this.Filter().Where(i => i.isCompleted == false).FirstOrDefault();
            if (currlist == null)
            {
                currlist = Create(new ListeDesCourses());
                currlist.dateDeListe = DateTime.Today;
                currlist.isCompleted = false;
                currlist.listeDesIngredients.Add(ing);
                SaveChanges();
                
            }
            else
            {
                currlist.listeDesIngredients.Add(ing);
                SaveChanges();
            }
        }
    }
}