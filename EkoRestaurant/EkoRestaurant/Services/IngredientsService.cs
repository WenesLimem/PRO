using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkoRestaurant.Data;
using EkoRestaurant.Services.Abstractions;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EkoRestaurant.Services
{
    public class IngredientsService : BaseDataService<Ingredient>
    {
        public IngredientsService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
