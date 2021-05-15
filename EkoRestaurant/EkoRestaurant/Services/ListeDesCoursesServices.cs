using System;
using System.Collections.Generic;
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


        public new ListeDesCourses Create(ListeDesCourses entity)
        {
            throw new ApplicationException("use GetActiveListeDesCourses() instead of Create()");
        }

        public ListeDesCourses AddIngredientToCurrent(ListeDesCoursesElement listeDesCoursesElement)
        {
            var current = GetActiveListeDesCourses();
            current.ListeDesCoursesElements.Add(listeDesCoursesElement);
            SaveChanges();
            return current;
        }

        public ListeDesCourses DeleteIngredientToCurrent(ListeDesCoursesElement listeSourceElement)
        {
            var current = GetActiveListeDesCourses();
            var success = current.ListeDesCoursesElements.Remove(listeSourceElement);
            if (!success)
            {
                throw new ApplicationException("error while removing from active liste de course");
            }
            SaveChanges();
            return current;
        }

        public ListeDesCourses GetActiveListeDesCourses()
        {
            var current = this.FilterWithIngredients().FirstOrDefault(x => x.IsCompleted == false);
            if (current == null)
            {
                // need to create the active list
                var newListe = new ListeDesCourses()
                {
                    CreationDateTime = DateTime.Now,
                    IsCompleted = false
                };

                var addedEntityEntry = _dbContext.Set<ListeDesCourses>().Add(newListe);
                SaveChanges();
                return addedEntityEntry.Entity;
            }

            return current;
        }

        public void MarkActiveAsCompleted()
        {
            var current = GetActiveListeDesCourses();
            current.IsCompleted = true;
            current.CompletionDateTime = DateTime.Now;
            SaveChanges();
        }

        public IEnumerable<ListeDesCourses> FilterWithIngredients()
        {
            return _dbContext.Set<ListeDesCourses>()
                .Include((x) => x.ListeDesCoursesElements)
                .ThenInclude(g => g.Ingredient);


        }
    }
}