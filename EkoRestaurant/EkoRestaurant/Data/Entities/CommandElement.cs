using System;
using EkoRestaurant.Data.Abstractions;

namespace EkoRestaurant.Data
{
    public class CommandElement : BaseEntity
    {
        public Recipe Recipe { get; set; }
        public Command Command { get; set; }
        public int Qty { get; set; }
        public String Remark { get; set; }
    }
}