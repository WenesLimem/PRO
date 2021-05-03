using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkoRestaurant.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
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
        public DbSet <ListeDesCourses> ListeDesCourses { get; set; }
    }
}
