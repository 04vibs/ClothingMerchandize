using System;
using System.Collections.Generic;
using System.Text;

namespace clothing
{
    /// <summary>
    /// Constant
    /// </summary>
    class Constants
    {
        public const String welcome = "*****************************************************";
        public const String welcomeMessage = "Today Weather is ";
        public const String ListMessage = "Products in Stock ";
        public const String UserMessage = "Welcome User for Shopping in the Clothing Merchandize";
        public const String BudgetQuery = "Enter your Budget";

        public const String ShoppingMessage = "Thank you for visting Clothing Merchandize";

        public const String QuesToUser = "This is the best Combo as per your budget ," +
                                                                " Do you want to buy this Combo";

        public const String EmptyList = "No Item in your budget";

        public const String ForUserResponse = "Enter Y for purchasing else Enter N for more combos";

        public const string FilePath = "E:\\TransactionData.txt";

        public static readonly string[] weather = new string[4] { "summer",
                                                   "winter",
                                                    "wind",
                                                    "rainy"
                                                };
        public const int noOfWeather = 4;

        public static readonly string[] Message = new string[4] { " Sunny day Enjoy your day",
                                                    " Cold wear warm clothes",
                                                    " Windy day be careful",
                                                            " Carry an umbrella"
                                                };
        public const String Combo = "Combo";

        public const String TableItems = "Title  \tWeather\tCategory\tPrice";

        public const String ComboMessage = "Let me show you more combos";


    }
}
