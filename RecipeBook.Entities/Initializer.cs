using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Entities
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseAlways<RecipeContext>
    {
        protected override void Seed(RecipeContext context)
        {
            // meal 1.


            Recipe panini = new Recipe()
            {
                Name = "Turkey Panini",
                Description = "Yummiest paninis ever!",
                DishType = DishType.MAIN_COURSE,
                MinutesToPrep = 10,
                MinutesToCook = 5,
                HealthLevel = HealthLevel.NOT_BAD,
                DifficultyLevel = DifficultyLevel.EASY,
                CookingNotes = "idk yet",
                //MealType = new List<MealType>() { MealType.LUNCH, MealType.DINNER },
                Steps = new List<String>()
                {

                    "Slice the tomatoes and pickles.",
                    "Preheat the panini press",
                    "Prepare the sandwhich with mayo on both sides of the bread, cheese on both sides, tukey folded, lettuce, tomato and pickles.",
                    "Put the sandwhich on the panini press and clamp closed for about 3 minutes, or until the cheese is melted and the bread is toasted."
                },
                IngredientSets = new List<IngredientSet>()
                {
                    new IngredientSet()
                    {
                        Ingredients = new List<Ingredient>()
                        {
                            new Ingredient() { Name = "Chibata Bread", Unit = 1, Measurement = Measurement.ITEM, GroceryNotes = "Best from Costco" },
                            new Ingredient() { Name = "Sliced Turkey", Unit = .25, Measurement = Measurement.LBS, GroceryNotes = "Ovengold or blackened" },
                            new Ingredient() { Name = "Tomato", Unit = 1, Measurement = Measurement.ITEM, GroceryNotes = "Large" },
                            new Ingredient() { Name = "Lettuce", Unit = 1, Measurement = Measurement.ITEM, GroceryNotes = "Romain or red leaf" },
                            new Ingredient() { Name = "Pickles", Unit = 1, Measurement = Measurement.ITEM, GroceryNotes = "" },
                            new Ingredient() { Name = "Spicy Mayo", Unit = 1, Measurement = Measurement.ITEM, GroceryNotes = "" },
                            new Ingredient() { Name = "Pepper Jack cheese", Unit = 1, Measurement = Measurement.ITEM, GroceryNotes = "Slices or block sliced later" }
                        }
                    }
                }
            };
            context.Recipies.Add(panini);

            context.SaveChanges();
        }
    }
}
