using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GroceryNotes { get; set; }

        public Measurement Unit { get; set; }

        public int Measurement { get; set; }

    }
}
