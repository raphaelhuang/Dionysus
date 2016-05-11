using Dionysus.Enum;
using Dionysus.Models;
using Dionysus.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dionysus.Controllers
{
    public class CocktailController : Controller
    {
        // GET: Cocktail
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddRecipe()
        {
            return View();
        }

        public ActionResult ShowCocktail()
        {
            CocktailViewModel cvm = new CocktailViewModel();
            cvm.cocktailList = GetShowCockail();

            return View(cvm);
        }

        private List<Cocktail> GetShowCockail()
        {
            List<Cocktail> cocktailList = new List<Cocktail>();


            Cocktail c1 = new Cocktail();
            c1.Id = 1;
            c1.Name = "Margarita";
            c1.Glass = GlassType.CocktailGlass;

            List<CocktailCategory> cList1 = new List<CocktailCategory>();
            cList1.Add(CocktailCategory.ClassicalCocktail);
            cList1.Add(CocktailCategory.GirlFavorite);

            c1.Category = cList1;
            c1.Colour = KnownColor.Azure;
            c1.Desc = "First Cocktail";
            c1.Skill = SkillType.Shake;
            c1.IsHot = false;
            c1.IsBubble = false;
            c1.IsFavorite = false;
            c1.Prep = "Shake Shake Shake";
            c1.Ingredients = new List<Ingredient> {
                new Ingredient { Id=1,Name="Tequila", Category=IngredientCategory.Tequila, Weight=1.5, Unit=UnitType.oz},
                new Ingredient { Id=2,Name="Triple Sec", Category=IngredientCategory.Flavor, Weight=.75, Unit=UnitType.oz},
                new Ingredient { Id=3,Name="Lemon Juice", Category=IngredientCategory.NoneAlcohol, Weight=.75, Unit=UnitType.oz},
                new Ingredient { Id=4,Name="Syrup", Category=IngredientCategory.NoneAlcohol, Weight=.5, Unit=UnitType.oz} };

            Cocktail c2 = new Cocktail();
            c2.Id = 2;
            c2.Name = "B52";
            c2.Glass = GlassType.Shot;

            List<CocktailCategory> cList2 = new List<CocktailCategory>();
            cList2.Add(CocktailCategory.EasyCocktail);
            cList2.Add(CocktailCategory.PopularCocktail);
            cList2.Add(CocktailCategory.GirlFavorite);

            c2.Category = cList2;
            c2.Colour = KnownColor.Brown;
            c2.Desc = "Second Cocktail";
            c2.Skill = SkillType.Build;
            c2.IsHot = false;
            c2.IsBubble = false;
            c2.IsFavorite = true;
            c2.Prep = "Layar Layar Layar";
            c2.Ingredients = new List<Ingredient> {
                new Ingredient { Id=1,Name="Kahlua", Category=IngredientCategory.Flavor, Weight=.5, Unit=UnitType.oz},
                new Ingredient { Id=2,Name="Bailey's", Category=IngredientCategory.Flavor, Weight=.5, Unit=UnitType.oz},
                new Ingredient { Id=3,Name="Grand Marnier", Category=IngredientCategory.Flavor, Weight=.5, Unit=UnitType.oz}};

            cocktailList.Add(c1);
            cocktailList.Add(c2);

            return cocktailList;
        }
    }
}