using System.Collections.Generic;
using EkoRestaurant.Data;
using EkoRestaurant.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace EkoRestaurant.Services
{
    public class ListeDesCoursesElementService : BaseDataService<ListeDesCoursesElement>
    {
        public ListeDesCoursesElementService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

     

    }
}   