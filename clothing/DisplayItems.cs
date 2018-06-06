using System;
using System.Collections.Generic;
using System.Text;

namespace clothing
{
    class DisplayItems
    {
        /// <summary>
        ///     Display method       
        /// </summary>
        /// <param name="productList"></param>
        public void DisplayProducts(List<Product> productList)
        {
            foreach (var product in productList)
            {
                Console.WriteLine("Items: {0},{1},{2},{3}", product.Title,
                                                                product.Weather,
                                                                product.Category,
                                                                     product.Price);
            }
        }
    }
}
