using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace EkoRestaurant.Shared
{
    /// <summary>
    /// Use this component to automatically redirect to login page
    /// </summary>
    public class RedirectToLogin : ComponentBase
    {
        [Inject]
        protected NavigationManager NavigationManager { get; set; }


        protected override void OnAfterRender(bool firstRender)
        {
            NavigationManager.NavigateTo("/login", true);
        }
    }
}
