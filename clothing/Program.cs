using System;
using System.Collections.Generic;

namespace clothing
{
    class Program
    {/// <summary>
    ///   Main method return
    ///   welcome Message
    ///   List of Products 
    ///   Shows Item in user Budget
    ///   show more budget if user doesn't wants to buy given combo
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Weather weather = new Weather();
            Budget Budget = new Budget();
            DisplayItems Display = new DisplayItems();
            ProductUtilities products = new ProductUtilities();
            Logging logData = new Logging();
            DifferentCombo diffCombo = new DifferentCombo();

            //Weather
            Console.WriteLine(Constants.welcome);
            Console.WriteLine(Constants.UserMessage);
            Console.WriteLine(Constants.welcomeMessage + weather.TodayWeather());
            Console.WriteLine(weather.Message());

            //List of products to get
            Console.WriteLine(Constants.welcome);
            Console.WriteLine(Constants.ListMessage);
            Console.WriteLine();
            List<Product> listOfProducts = products.GetItems();//new List<Product>();
            //list = products.GetItems();
            Display.DisplayProducts(listOfProducts);
            Console.WriteLine(Constants.welcome);

            //User Budget
            Console.WriteLine(Constants.BudgetQuery);
            //cost
            int cost = 0;

            //Items In User Budget
            List<Product> userItems = Budget.UserBudgetItem();
            if (userItems.Count == 0)
            {
                Console.WriteLine(Constants.EmptyList);
            }
            else
            {
                Display.DisplayProducts(userItems);

                //User Response to know if he wants to  buy or Not
                Console.WriteLine(Constants.QuesToUser);
                Console.WriteLine(Constants.ForUserResponse);
                char userAns = UserResponse.Response();
                if (userAns == 'y' || userAns == 'Y')
                {
                    logData.EventProgram(userItems);
                    Console.WriteLine(Constants.ShoppingMessage);

                    // logData.logdata(userItems);
                }
                if (userAns == 'n' || userAns == 'N')
                {
                    Console.WriteLine(Constants.welcome);
                    Console.WriteLine(Constants.ComboMessage);
                    //Console.WriteLine(listOfProducts.Count);
                    List<Product> moreCombo = diffCombo.MoreCombos(Budget.GetBudget(), listOfProducts);
                    //  Console.WriteLine("Inside");
                    if (moreCombo.Count == 0)
                    {
                        Console.WriteLine(Constants.EmptyList);
                    }
                    else
                    {
                        Display.DisplayProducts(moreCombo);
                        //again ques if user wants to buy or not

                        Console.WriteLine(Constants.QuesToUser);
                        Console.WriteLine(Constants.ForUserResponse);
                        char userAns1 = UserResponse.Response();
                        if (userAns1 == 'y' || userAns1 == 'Y')
                        {
                            logData.EventProgram(moreCombo);
                            Console.WriteLine(Constants.ShoppingMessage);
                        }
                        else if (userAns1 == 'N' || userAns1 == 'n')
                        {
                            Console.WriteLine(Constants.ShoppingMessage);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}