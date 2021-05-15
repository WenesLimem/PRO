using EkoRestaurant.Data.Abstractions;

namespace EkoRestaurant.Data
{
    public class ListeDesCoursesElement : BaseEntity
    {
        public Ingredient Ingredient { get; set; }
        public ListeDesCourses ListeDesCourses { get; set; }
        
        public int Quantity { get; set; }
        
        
    }
}