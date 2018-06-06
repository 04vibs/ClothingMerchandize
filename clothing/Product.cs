using System;
using System.Collections.Generic;
using System.Text;

namespace clothing
{
    /// <summary>
    /// get and set the products
    /// </summary>
    class Product
    {

        public Product(string title, string weather, string category, int price)
        {
            this.Title = title;
            this.Weather = weather;
            this.Category = category;
            this.Price = price;
        }
        
        public string Title
        {
            get;  set;
            
        }

        public string Category
        {
            get; set;
        }
        public string Weather
        {
            get;set;
        }

        public int Price
        {
            get;set;
        }

    }
}
