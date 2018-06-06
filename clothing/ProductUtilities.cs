using System;
using System.Collections.Generic;
using System.Text;

namespace clothing
{
    class ProductUtilities
    {   /// <summary>
    /// Add the list of Items
    /// </summary>
    /// <returns>List of product</returns>
        public List<Product> GetItems()
        {
            var listOfProducts = new List<Product>();
            listOfProducts.Add(new Product("Shirt     ", " Summer", "Formal",    11));
            listOfProducts.Add(new Product("TShirt    ", " Rain  ", "Formal",    13));
            listOfProducts.Add(new Product("Trouser   ", " Rain  ", "Formal",    19));
            listOfProducts.Add(new Product("Shirt     ", " wind  ", "casual",    23));
            listOfProducts.Add(new Product("SweatShirt", " winter", "Formal",    26));
            listOfProducts.Add(new Product("sweatshirt", " Summer", "casual",    29));
            listOfProducts.Add(new Product("Pent      ", " Summer", "casual",    31));
            listOfProducts.Add(new Product("Jean      ", " Rain  ", "Formal",    37));
            listOfProducts.Add(new Product("LongCoat  ", " Winter", "Formal",    41));
            listOfProducts.Add(new Product("coat      ", " Winter", "Formal",    91));
           

            return listOfProducts;
        }
    }
}