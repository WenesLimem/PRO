using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace EkoRestaurant.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public static Guid ADMIN_ROLE_GUID = new Guid("799913B3-7269-43CB-B646-815ECC1AF340");
        public static Guid EMPLOYEE_ROLE_GUID = new Guid("B8C9FAA7-E1A1-433A-9105-EF7589BC7823");
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// method overriden to provide fake data (useful for development)
        /// </summary>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // see: https://docs.microsoft.com/en-us/ef/core/modeling/data-seeding#:~:text=Custom%20initialization%20logic-,Model%20seed%20data,new%20version%20of%20the%20model.

        }

        public DbSet<DailyMenu> DailyMenus { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientCategory> IngredientCategories { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeCategory> RecipeCategories { get; set; }
    }
}
