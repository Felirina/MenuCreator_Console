using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCreator
{
    // The Enum's main point is to act as a Flag - a list of possible values 
    // which we can use to choose from.
    // It is used to controller the developer which values they can use
    // and which value the application can request or accept.
    public enum RecipeType  
    {
        Breakfast,
        MorningSnack,
        Lunch,
        AfternoonSnack,
        Dinner,
    }
}
