using System;
using EkoRestaurant.Data;
using EkoRestaurant.Data.Entities;
using EkoRestaurant.Services.Abstractions;

namespace EkoRestaurant.Services
{
    public class ClientCommandService : BaseDataService<ClientCommand>
    {
        public ClientCommandService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
