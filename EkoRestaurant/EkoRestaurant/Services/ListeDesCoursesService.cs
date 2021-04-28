using System.Collections.Generic;
using EkoRestaurant.Data;
using Microsoft.EntityFrameworkCore;
using EkoRestaurant.Services.Abstractions;


namespace EkoRestaurant.Services
{
    public class ListeDesCoursesService : BaseDataService<ListeDesCourses>
    {
        public ListeDesCoursesService(ApplicationDbContext dbContext) : base(dbContext)
        {
           
        }
    }
}