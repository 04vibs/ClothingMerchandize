using System;
using System.Collections.Generic;
using System.Text;

namespace clothing
{   
    /// <summary>
    /// Creates Different combo according to weather 
    /// </summary>
    class DifferentCombo
    {
        Weather weather = new Weather();
        /// <summary>
        /// get user budget
        /// </summary>
        /// <param name="Budget"></param>
        /// <param name="productList"></param>
        /// <returns> list of products according to weather and user budget</returns>
        public List<Product> MoreCombos(int Budget,List<Product> productList)
        {
          
            List<Product> diffCombo = new List<Product>();  
            productList.Sort((x, y) => x.Price.CompareTo(y.Price));
            int lengthOfExistingProducts = productList.Count;
            int iteminList = lengthOfExistingProducts - 1;
            while (Budget > 0 && iteminList >= 0   )
            {
                if (Budget > productList[iteminList].Price && productList[iteminList].Weather.Trim().ToLower() == weather.TodayWeather())
                {
                    Budget = Budget - productList[iteminList].Price;
                    diffCombo.Add(productList[iteminList]);
            
                }
                iteminList--;
            }
             return diffCombo;
        }
        

    }
}
