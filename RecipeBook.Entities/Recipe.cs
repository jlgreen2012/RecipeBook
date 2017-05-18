using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Entities
{
    public class Recipe
    {
        public Recipe() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string CookingNotes { get; set; }

        public ICollection<MealType> MealType { get; set; }

        public DishType DishType { get; set; }

        public HealthLevel HealthLevel { get; set; }

        public int MinutesToPrep { get; set; }

        public int MinutesToCook { get; set; }

        public DifficultyLevel DifficultyLevel { get; set; }

    }
}
