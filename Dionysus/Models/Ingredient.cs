using Dionysus.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dionysus.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IngredientCategory Category { get; set; }
        public decimal Weight { get; set; }
        public UnitType Unit { get; set; }
    }
}