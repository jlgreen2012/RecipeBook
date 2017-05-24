using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Entities
{
    public class Recipe
    {
        public Recipe() { }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string CookingNotes { get; set; }

        //[MinLength(1, ErrorMessage = "At least one meal type is required.")]
        //public virtual ICollection<MealType> MealType { get; set; }

        public DishType DishType { get; set; }

        public HealthLevel HealthLevel { get; set; }

        public int MinutesToPrep { get; set; }

        public int MinutesToCook { get; set; }

        public DifficultyLevel DifficultyLevel { get; set; }

        [Url]
        public string OriginalRecipeUrl { get; set; }

        public string OriginalRecipeNotes { get; set; }

        //[MinLength(1, ErrorMessage = "At least one ingredient set is required.")]
        public virtual ICollection<IngredientSet> IngredientSets { get; set; }

        //[MinLength(1, ErrorMessage = "At least one step is required.")]
        public virtual ICollection<string> Steps { get; set; }
        
        public virtual ICollection<Meal> Meals { get; set; } // meals this recipe belongs to. 


    }
}
