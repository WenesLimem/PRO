using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkoRestaurant.Data.Abstractions;

namespace EkoRestaurant.Data.Entities
{
    public class ClientCommand : BaseEntity
    {

        public string ClientName { get; set; }
        public string ClientPhone { get; set; }

        public DateTime DateTimeOrder { get; set; }
        public DateTime DateTimeStartCooking { get; set; }

        public DateTime DateTimeFinished { get; set; }

        public OrderState State { get; set; }

        public List<ClientCommandElement> Elements { get; set; } = new();

    }


    public enum OrderState
    {
        ORDERED = 0,
        COOKING,
        FINISHED,
        PAYED
    }
}
