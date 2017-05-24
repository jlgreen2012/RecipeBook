using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Entities
{
    public class IngredientSet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "Ingredients"; // default to ingredients, especially if there is only one set. 

        //[MinLength(1, ErrorMessage = "At least one ingredient is required.")]
        public virtual ICollection<Ingredient> Ingredients { get; set; }

        public virtual Recipe Recipe { get; set; }

    }
}
