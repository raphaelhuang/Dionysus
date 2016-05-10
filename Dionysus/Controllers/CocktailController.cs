using Dionysus.Enum;
using Dionysus.Models;
using Dionysus.ViewModel;
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

        public ActionResult xxShowCocktail()
        {
            return View();
        }

        //private List<CocktailViewModel> GetShowCockail()
        public ActionResult ShowCocktail()
        {
            List<CocktailViewModel> cocktailList = new List<CocktailViewModel>();


            CocktailViewModel c1 = new CocktailViewModel();
            c1.cocktail.Id = 1;
            c1.cocktail.Name = "Margarita";
            c1.cocktail.Glass = GlassType.CocktailGlass;

            List<CocktailCategory> cList1 = new List<CocktailCategory>();
            cList1.Add(CocktailCategory.ClassicalCocktail);
            cList1.Add(CocktailCategory.GirlFavorite);

            c1.cocktail.Category = cList1;
            c1.cocktail.Colour = KnownColor.Azure;
            c1.cocktail.Desc = "First Cocktail";
            c1.cocktail.Skill = SkillType.Shake;
            c1.cocktail.IsHot = false;
            c1.cocktail.IsBubble = false;
            c1.cocktail.IsFavorite = false;
            c1.cocktail.Prep = "Shake Shake Shake";
            c1.cocktail.Ingredients = new List<Ingredient> {
                new Ingredient { Id=1,Name="Tequila", Category=IngredientCategory.Tequila, Weight=1.5, Unit=UnitType.oz},
                new Ingredient { Id=2,Name="Triple Sec", Category=IngredientCategory.Flavor, Weight=.75, Unit=UnitType.oz},
                new Ingredient { Id=3,Name="Lemon Juice", Category=IngredientCategory.NoneAlcohol, Weight=.75, Unit=UnitType.oz},
                new Ingredient { Id=4,Name="Syrup", Category=IngredientCategory.NoneAlcohol, Weight=.5, Unit=UnitType.oz} };

            CocktailViewModel c2 = new CocktailViewModel();
            c2.cocktail.Id = 2;
            c2.cocktail.Name = "B52";
            c2.cocktail.Glass = GlassType.Shot;

            List<CocktailCategory> cList2 = new List<CocktailCategory>();
            cList2.Add(CocktailCategory.EasyCocktail);
            cList2.Add(CocktailCategory.PopularCocktail);
            cList2.Add(CocktailCategory.GirlFavorite);

            c2.cocktail.Category = cList2;
            c2.cocktail.Colour = KnownColor.Brown;
            c2.cocktail.Desc = "Second Cocktail";
            c2.cocktail.Skill = SkillType.Build;
            c2.cocktail.IsHot = false;
            c2.cocktail.IsBubble = false;
            c2.cocktail.IsFavorite = true;
            c2.cocktail.Prep = "Layar Layar Layar";
            c2.cocktail.Ingredients = new List<Ingredient> {
                new Ingredient { Id=1,Name="Kahlua", Category=IngredientCategory.Flavor, Weight=.5, Unit=UnitType.oz},
                new Ingredient { Id=2,Name="Bailey's", Category=IngredientCategory.Flavor, Weight=.5, Unit=UnitType.oz},
                new Ingredient { Id=3,Name="Grand Marnier", Category=IngredientCategory.Flavor, Weight=.5, Unit=UnitType.oz}};

            cocktailList.Add(c1);
            cocktailList.Add(c2);

            return View("ShowCocktail", cocktailList);
            //return cocktailList;
        }
    }
}