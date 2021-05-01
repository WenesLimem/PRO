using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkoRestaurant.Data;
using Microsoft.AspNetCore.Identity;

namespace EkoRestaurant.IdentityUtils
{
    public static class UserManageExtensions
    {
        private const string LoginPurpose = "Login";

        public static async Task<string> GenerateUserTokenForLoginAsync(this UserManager<ApplicationUser> userManager, ApplicationUser user, string tokenProvider)
        {
            return await userManager.GenerateUserTokenAsync(user, tokenProvider, LoginPurpose);
        }

        public static async Task<bool> VerifyUserTokenForLoginAsync(this UserManager<ApplicationUser> userManager, ApplicationUser user, string tokenProvider, string token)
        {
            return await userManager.VerifyUserTokenAsync(user, tokenProvider, LoginPurpose, token);
        }

    }
}
