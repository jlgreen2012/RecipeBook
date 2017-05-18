using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Entities
{
    public class Meal
    {
        public ICollection<Recipe> Recipes { get; set; }
        public HealthLevel HealthLevel { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateLastCooked { get; set; }

        public bool WasCreated { get; set; } // created by hand versus suggested..?
    }
}
