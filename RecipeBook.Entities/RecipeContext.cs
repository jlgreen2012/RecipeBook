using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Entities
{
    public class RecipeContext : DbContext
    {
        public RecipeContext() : base("RecipeDb")
        {
        }

        public DbSet<Recipe> Recipies { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientSet> IngredientSets { get; set; }

        private void InitializeDatabase()
        {
            Database.SetInitializer(new Initializer());
            //if (!Database.Exists())
            //{
                Database.Initialize(true);
            //}
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Set up one-many, many-many relationships.
            // best explanation i found: http://www.c-sharpcorner.com/UploadFile/a3d5d0/creating-many-to-many-mapping-using-code-first-entity-frame/
            modelBuilder.Entity<Meal>()
                .HasMany(m => m.Recipes)
                .WithMany(r => r.Meals)
                .Map(m =>
                {
                    m.MapLeftKey("MealId");
                    m.MapRightKey("RecipeId");
                    m.ToTable("MealRecipe");
                });
            modelBuilder.Entity<Recipe>()
                .HasMany(r => r.IngredientSets)
                .WithRequired(i => i.Recipe)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<IngredientSet>()
                .HasMany(s => s.Ingredients)
                .WithRequired(i => i.IngredientSet)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Ingredient>()
            //    .HasRequired<IngredientSet>(i => i.IngredientSet)
            //    .WithMany(s => s.Ingredients)
            //    .WillCascadeOnDelete(false);
        }
    }
}
