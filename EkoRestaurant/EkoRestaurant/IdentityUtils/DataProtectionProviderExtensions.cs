using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;

namespace EkoRestaurant.IdentityUtils
{
    public static class DataProtectionProviderExtensions
    {
        public static IDataProtector CreateProtectorForLogin(this IDataProtectionProvider dataProtectionProvider)
        {
            return dataProtectionProvider.CreateProtector("Login");
        }
    }
}
