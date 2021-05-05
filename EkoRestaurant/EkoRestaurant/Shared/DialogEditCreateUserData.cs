using System;
using System.Collections.Generic;
using EkoRestaurant.Data;

namespace EkoRestaurant.Shared
{
    public class DialogEditCreateUserData
    {
        public ApplicationUser User { get; set; }
        public String Role { get; set; }

        public String Password { get; set; }
    }
}