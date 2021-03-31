using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkoRestaurant.Data.Abstractions
{
    /// <summary>
    /// define base entity to stock in the database
    /// </summary>
    public abstract class BaseEntity
    {

        /// <summary>
        /// Primary key
        /// </summary>
        public int Id { get; set; } 
    }
}
