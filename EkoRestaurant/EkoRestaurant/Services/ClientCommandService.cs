using System;
using System.Collections.Generic;
using System.Linq;
using EkoRestaurant.Data;
using EkoRestaurant.Data.Entities;
using EkoRestaurant.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace EkoRestaurant.Services
{
    public class ClientCommandService : BaseDataService<ClientCommand>
    {
        public ClientCommandService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<ClientCommand> FilterWithRecipes(Func<ClientCommand, bool> predicate)
        {
            return _dbContext.Set<ClientCommand>()
                .Include((x) => x.Elements)
                    .ThenInclude((c) => c.Recipe)
                .Where(predicate);
        }
    }
}
