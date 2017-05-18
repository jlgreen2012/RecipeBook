using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Entities
{
    public enum Measurement
    {
        [Display(Name ="pinch")]
        PINCH,

        [Display(Name ="cup")]
        CUP,

        [Display(Name ="oz")]
        OZ,

        [Display(Name ="Tbs")]
        TBS,

        [Display(Name ="tsp")]
        TSP,

        [Display(Name ="quarts")]
        QUARTZ,

        [Display(Name ="pints")]
        PINTS,

        [Display(Name ="grams")]
        GRAMS
    }
}
