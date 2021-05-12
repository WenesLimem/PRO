using System;
using System.Collections.Generic;
using EkoRestaurant.Data.Abstractions;

namespace EkoRestaurant.Data
{
    public class Command : BaseEntity
    {
        public String ClientName;
        public String ClientPhoneNumber;

        public DateTime DateTimeOfCommand;
        public DateTime DateTimeStartCooking;
        
        public List<CommandElement> CommandElements = new List<CommandElement>();
    }
}