using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkoRestaurant.Data;
using Microsoft.AspNetCore.Identity;

namespace EkoRestaurant
{
    public static class ApplicationDbInitialiser
    {
        public static String ADMINISTRATOR_ROLE_NAME = "Administrator";
        public static String EMPLOYEE_ROLE_NAME = "Employee";
        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            AddRoleIfNotExists(roleManager, ADMINISTRATOR_ROLE_NAME);
            AddRoleIfNotExists(roleManager, EMPLOYEE_ROLE_NAME);
        }

        public static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            (string name, string password, string role)[] demoUsers = new[]
            {
                (name: "Administrator", password: "Administrator+1", role: ADMINISTRATOR_ROLE_NAME),
                (name: "Employee", password: "Employee+1", role: EMPLOYEE_ROLE_NAME),
                (name: "fred@fred.com", password: "Passw0rd!", role: "")
            };

            foreach ((string name, string password, string role) user in demoUsers)
            {
                AddUserIfNotExists(userManager, user);
            }

        }

        public static void AddUserIfNotExists(UserManager<ApplicationUser> userManager, (string name, string password, string role) demoUser)
        {
            ApplicationUser user = userManager.FindByNameAsync(demoUser.name).Result;
            if (user == default)
            {
                var newAppUser = new ApplicationUser
                {
                    UserName = demoUser.name,
                    Email = demoUser.name,
                    EmailConfirmed = true
                };
                _ = userManager.CreateAsync(newAppUser, demoUser.password).Result;
                if (!string.IsNullOrWhiteSpace(demoUser.role))
                {
                    var roles = demoUser.role.Split(',').Select(a => a.Trim()).ToArray();
                    Console.WriteLine($"{roles.Length}");
                    foreach (var role in roles)
                    {
                        _ = userManager.AddToRoleAsync(newAppUser, role).Result;
                    }
                }

            }
        }

        public static void AddRoleIfNotExists(RoleManager<IdentityRole> roleManager, string roleName)
        {
            if (roleManager.FindByNameAsync(roleName).Result == default)
            {
                roleManager.CreateAsync(new IdentityRole { Name = roleName }).Wait();
            }
        }
    }
}
