using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Entities
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string IngredientNotes { get; set; }

        public string GroceryNotes { get; set; }

        public double Unit { get; set; }

        public Measurement Measurement { get; set; }

        public int IngredientSetId { get; set; }
        public virtual IngredientSet IngredientSet { get; set; }

    }
}
