using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkoRestaurant.Data
{
    public class DailyMenu : BaseEntity
    {
        public Recipe Starter { get; set; }
        public Recipe MainDish { get; set; }
        public Recipe Dessert { get; set; }
    }
}
