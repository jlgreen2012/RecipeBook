using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Entities
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "At least one recipe is required.")]
        public ICollection<Recipe> Recipes { get; set; }

        public HealthLevel HealthLevel { get; set; }

        public DateTime? DateAdded { get; set; }

        public DateTime? DateLastCooked { get; set; }        
    }
}
