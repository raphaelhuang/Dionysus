using Dionysus.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Dionysus.Models
{
    public class Cocktail
    {
        public Cocktail()
        {
            Ingredients = new HashSet<Ingredient>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public GlassType Glass { get; set; }
        public CocktailCategory Category { get; set; }
        public SkillType Skill { get; set; }
        public KnownColor Colour { get; set; }
        public string Prep { get; set; }
        public string Desc { get; set; }
        public bool IsBubble { get; set; }
        public bool IsHot { get; set; }
        public bool IsFavorite { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}