using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkoRestaurant.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;


namespace EkoRestaurant.IdentityUtils
{
    public class LoginService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly NavigationManager _navigationManager;
        private readonly IDataProtectionProvider _dataProtectionProvider;


        public LoginService(
            UserManager<ApplicationUser> userManager,
            NavigationManager navigationManager,
            IDataProtectionProvider dataProtectionProvider)
        {
            _userManager = userManager;
            _navigationManager = navigationManager;
            _dataProtectionProvider = dataProtectionProvider;

        }

        /// <summary>
        /// Logs in the current user.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task Login(ApplicationUser user, bool rememberMe)
        {
            var token = await _userManager.GenerateUserTokenForLoginAsync(user, TokenOptions.DefaultProvider);
            var data = $"{user.Id}|{token}|{rememberMe}";
            var protector = _dataProtectionProvider.CreateProtectorForLogin();
            var protectedData = protector.Protect(data);

            // Delegate the actual work to navigation, because internally, it has to do a SignOIn operation,
            // which will not work in a Blazor context.
            _navigationManager.NavigateTo("/Account/LoginInternal?t=" + protectedData, true);

        }
    }
}
