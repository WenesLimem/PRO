using EkoRestaurant.Data;
using EkoRestaurant.Services.Abstractions;

namespace EkoRestaurant.Services
{
    public class CommandsServices : BaseDataService<Command>
    {
        public CommandsServices(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}