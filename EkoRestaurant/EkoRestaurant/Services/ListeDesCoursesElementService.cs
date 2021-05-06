using EkoRestaurant.Data;
using EkoRestaurant.Services.Abstractions;

namespace EkoRestaurant.Services
{
    public class ListeDesCoursesElementService : BaseDataService<ListeDesCoursesElement>
    {
        public ListeDesCoursesElementService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    
        
    }
}   