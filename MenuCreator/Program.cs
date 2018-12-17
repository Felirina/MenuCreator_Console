using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCreator
{
    class Program
    {
        static RecipeManager manager = new RecipeManager();

        static void Main(string[] args)
        {
            MyRecipes();


            Recipe[] recipes = manager.GetDailyMenu();


            Console.WriteLine(" Monday ");
            Console.WriteLine(recipes[0].recipeName);
            Console.WriteLine(recipes[1].recipeName);
            Console.WriteLine(recipes[2].recipeName);
            Console.WriteLine(recipes[3].recipeName);
            Console.WriteLine(recipes[4].recipeName);
            Console.WriteLine("");
            Console.WriteLine("");


            recipes = manager.GetDailyMenu();

            Console.WriteLine(" Tuesday ");
            Console.WriteLine(recipes[0].recipeName);
            Console.WriteLine(recipes[1].recipeName);
            Console.WriteLine(recipes[2].recipeName);
            Console.WriteLine(recipes[3].recipeName);
            Console.WriteLine(recipes[4].recipeName);
            Console.WriteLine("");
            Console.WriteLine("");

            recipes = manager.GetDailyMenu();

            Console.WriteLine(" Wednesday ");
            Console.WriteLine(recipes[0].recipeName);
            Console.WriteLine(recipes[1].recipeName);
            Console.WriteLine(recipes[2].recipeName);
            Console.WriteLine(recipes[3].recipeName);
            Console.WriteLine(recipes[4].recipeName);
            Console.WriteLine("");
            Console.WriteLine("");

            recipes = manager.GetDailyMenu();

            Console.WriteLine(" Thursday ");
            Console.WriteLine(recipes[0].recipeName);
            Console.WriteLine(recipes[1].recipeName);
            Console.WriteLine(recipes[2].recipeName);
            Console.WriteLine(recipes[3].recipeName);
            Console.WriteLine(recipes[4].recipeName);
            Console.WriteLine("");
            Console.WriteLine("");

            recipes = manager.GetDailyMenu();

            Console.WriteLine(" Friday ");
            Console.WriteLine(recipes[0].recipeName);
            Console.WriteLine(recipes[1].recipeName);
            Console.WriteLine(recipes[2].recipeName);
            Console.WriteLine(recipes[3].recipeName);
            Console.WriteLine(recipes[4].recipeName);
            Console.WriteLine("");
            Console.WriteLine("");

            recipes = manager.GetDailyMenu();

            Console.WriteLine(" Saturday ");
            Console.WriteLine(recipes[0].recipeName);
            Console.WriteLine(recipes[1].recipeName);
            Console.WriteLine(recipes[2].recipeName);
            Console.WriteLine(recipes[3].recipeName);
            Console.WriteLine(recipes[4].recipeName);
            Console.WriteLine("");
            Console.WriteLine("");

            recipes = manager.GetDailyMenu();

            Console.WriteLine(" Sunday ");
            Console.WriteLine(recipes[0].recipeName);
            Console.WriteLine(recipes[1].recipeName);
            Console.WriteLine(recipes[2].recipeName);
            Console.WriteLine(recipes[3].recipeName);
            Console.WriteLine(recipes[4].recipeName);
            Console.WriteLine("");
            Console.WriteLine("");






            Console.ReadLine();
        }

        private static void MyRecipes()
        {
            // manager.AddNewRecipe("Tojasos salata", RecipeType.Lunch);

            manager.AddNewRecipe("  Breakfast: Tojasos lecso + salata ", RecipeType.Breakfast);
            manager.AddNewRecipe("  Breakfast: Gombas tojas + salata ", RecipeType.Breakfast);
            manager.AddNewRecipe("  Breakfast: Zoldfuszeres, paradicsomos tojaskrem + salata ", RecipeType.Breakfast);
            manager.AddNewRecipe("  Breakfast: Gombafejekben sult tukortojas + salata ", RecipeType.Breakfast);
            manager.AddNewRecipe("  Breakfast: Forrocsoki, rantotta + salata", RecipeType.Breakfast);
            manager.AddNewRecipe("  Breakfast: Extra halas martogato + salata ", RecipeType.Breakfast);
            manager.AddNewRecipe("  Breakfast: Snidlinges omlett fott sonka csikokkal ", RecipeType.Breakfast);
            manager.AddNewRecipe("  Breakfast: Konnyu sonkas omlett + salata ", RecipeType.Breakfast);

            manager.AddNewRecipe("  Morning snack: Gyomberes keksz ", RecipeType.MorningSnack);

            manager.AddNewRecipe("  Lunch: Fuszeres, almas csirke + karfiol rizs", RecipeType.Lunch);
            manager.AddNewRecipe("  Lunch: Salata majjal es tojassal ", RecipeType.Lunch);
            manager.AddNewRecipe("  Lunch: Fasirt + zoldsegpure vagy karfiol rizs ", RecipeType.Lunch);
            manager.AddNewRecipe("  Lunch: Breaded fish + karfiol rizs vagy zoldsegpure  ", RecipeType.Lunch);
            manager.AddNewRecipe("  Lunch: Cordon bleu + zoldsegpure vagy karfiol rizs  ", RecipeType.Lunch);
            manager.AddNewRecipe("  Lunch: Brokkolis karfiol fozelek + fasirt  ", RecipeType.Lunch);
            manager.AddNewRecipe("  Lunch: Stefania vagdalt + karfiol rizs  ", RecipeType.Lunch);
            manager.AddNewRecipe("  Lunch: Csirkemajas rizotto ", RecipeType.Lunch);
            manager.AddNewRecipe("  Lunch: Bacskai rizseshus, cekla salata ", RecipeType.Lunch);

            manager.AddNewRecipe("  Afternoon snack: Tea ", RecipeType.AfternoonSnack);

            manager.AddNewRecipe("  Dinner: Gyors es laktato pizza ", RecipeType.Dinner);
            manager.AddNewRecipe("  Dinner: Teli serpenyos egytaletel ", RecipeType.Dinner);
            manager.AddNewRecipe("  Dinner: Mustaros tonhalmartogato ", RecipeType.Dinner);
            manager.AddNewRecipe("  Dinner: Vajas hal + zoldseg ", RecipeType.Dinner);
            manager.AddNewRecipe("  Dinner: Tojasos karfiol rizs sonka csikokkal ", RecipeType.Dinner);
            manager.AddNewRecipe("  Dinner: Extra halas martogato + salata ", RecipeType.Dinner);










        }
    }
}
