
using System.Net;

namespace DrinksInfo
{
    public class Validation
    {
        public static bool CategoryValidation(List<Category> categories, string userInput)
        {
            bool valid = false;
            int num;

            if (int.TryParse(userInput, out num))

                if (num < categories.Count && num >= 0 || num == 11) valid = true;

            return valid;
        }

        internal static bool DrinkValidation(List<DrinkDB> favDrinks, string category, List<Drink> drinks, string? userInput)
        {
            bool valid = false;
            if (category != "Favorite Drinks")
            {
                if (drinks.Any(drink => drink.idDrink == userInput)) valid = true;
            }
            else 
            {
                if (favDrinks.Any(drink => drink.Id == userInput)) valid = true;
            }
            return valid;
        }
    }
}