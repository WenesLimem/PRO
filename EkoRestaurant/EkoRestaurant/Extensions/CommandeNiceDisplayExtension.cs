using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkoRestaurant.Data.Entities;

namespace EkoRestaurant.Extensions
{
    public static class CommandeNiceDisplayExtension
    {

        public static double GetTotalPrice(this ClientCommand command)
        {
            double total = 0;

            foreach (ClientCommandElement element in command.Elements)
            {
                total += element.Quantity * element.Recipe.Price;
            }

            return total;
        }
    }
}
