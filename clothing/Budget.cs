using System;
using System.Collections.Generic;
using System.Text;

namespace clothing
{
    /// <summary>
    /// Takes input of budget from user
    /// </summary>
    class Budget
    {
        int budget;
        /// <summary>
        /// get budget
        /// </summary>
        /// <returns>budget</returns>

        public int GetBudget()
        {
            return budget;
        }

        /// <summary>
        /// creates combo according to user budget 
        /// </summary>
        /// <returns> list of products in user budget</returns>
        public List<Product> UserBudgetItem()
        {
            try
            {
                ProductUtilities productutilities = new ProductUtilities();
                //Read the user budget
                budget = int.Parse(Console.ReadLine());

                //products items in userbudgetList
                List<Product> userBudgetItems = productutilities.GetItems(); ;

                //sort
                userBudgetItems.Sort((x, y) => x.Price.CompareTo(y.Price));
                int lengthOfExistingProducts = userBudgetItems.Count;
                int itemsInList = lengthOfExistingProducts - 1;

                List<Product> userItems = new List<Product>();

                int moneySpent = default(Int32);

                while (budget > moneySpent && itemsInList >= 0)
                {
                    if ((budget - moneySpent) > userBudgetItems[itemsInList].Price)
                    {
                        
                        moneySpent = moneySpent + userBudgetItems[itemsInList].Price;
                        userItems.Add(userBudgetItems[itemsInList]);
                    }
                    itemsInList--;
                }
                return userItems;
            }
            catch(FormatException e)
            {
                throw e;
            }
            catch (Exception )
            {
                throw new Exception("please enter only the integer value");
            }
        }


    }
}