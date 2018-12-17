using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCreator
{
    class RecipeManager
    {
        List<Recipe> breakfastList = new List<Recipe>();
        List<Recipe> morningsnackList = new List<Recipe>();
        List<Recipe> lunchList = new List<Recipe>();
        List<Recipe> afternoonSnackList = new List<Recipe>();
        List<Recipe> dinnerList = new List<Recipe>();

        Random random;

        // This is the constructor - the first method which will run when the class get created
        // after calling it with the new keyword ( new RecipeManager()   )
        public RecipeManager()
        {
            int weekOfYear = GetIso8601WeekOfYear(DateTime.Now) + DateTime.Now.Year;

            random = new Random(weekOfYear);
        }

        public void AddNewRecipe(string recipeName, RecipeType type)
        {
            Recipe recipe = new Recipe();

            recipe.recipeName = recipeName;
            recipe.recipeType = type;

            if (type == RecipeType.Breakfast)
            {
                breakfastList.Add(recipe);
            }
            else if (type == RecipeType.MorningSnack)
            {
                morningsnackList.Add(recipe);
            }
            else if (type == RecipeType.Lunch)
                lunchList.Add(recipe);
            else if (type == RecipeType.AfternoonSnack)
            {
                afternoonSnackList.Add(recipe);
            }
            else if (type == RecipeType.Dinner)
                dinnerList.Add(recipe);

        }

        public Recipe[] GetDailyMenu()
        {
            Recipe[] recipes = new Recipe[5];
            int index;

            index = random.Next(0, breakfastList.Count);
            recipes[0] = breakfastList[index];

            index = random.Next(0, morningsnackList.Count);
            recipes[1] = morningsnackList[index];

            index = random.Next(0, lunchList.Count);
            recipes[2] = lunchList[index];

            index = random.Next(0, afternoonSnackList.Count);
            recipes[3] = afternoonSnackList[index];

            index = random.Next(0, dinnerList.Count);
            recipes[4] = dinnerList[index];

            return recipes;
        }


        // This presumes that weeks start with Monday.
        // Week 1 is the 1st week of the year with a Thursday in it.
        private int GetIso8601WeekOfYear(DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}
