using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkoRestaurant.Data.Abstractions;

namespace EkoRestaurant.Data.Entities
{
    public class ClientCommandElement : BaseEntity
    {
        public Recipe Recipe { get; set; }
        public int Quantity { get; set; }

        public String Remark { get; set; }
    }
}
