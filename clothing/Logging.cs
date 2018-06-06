using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace clothing
{
    /// <summary>
    /// Log the User Data
    /// </summary>
    class Logging
    {
        public delegate void LoggerEvent(List<Product> dellist);
        event LoggerEvent MyEvent;
        /// <summary>
        /// Call the event to log data
        /// </summary>
        /// <param name="product"></param>
        /// 

        public void EventProgram(List<Product> product)
        {
            MyEvent += new LoggerEvent(LogProducts);
            MyEvent(product);
        }

        public void LogProducts(List<Product> combo)
        {
            try
            {
                //Console.WriteLine(combo.Count);

                if (!File.Exists(Constants.FilePath))
                {
                    File.Create(Constants.FilePath);
                }
                FileStream fileStream = new FileStream(Constants.FilePath, FileMode.OpenOrCreate);

                using (StreamWriter sw = new StreamWriter(fileStream))
                {

                    sw.WriteLine(Constants.Combo);
                    sw.WriteLine(Constants.TableItems);

                    foreach (var comboItems in combo)
                    {
                        sw.WriteLine(comboItems.Title + "\t"
                                            + comboItems.Weather + "\t"
                                                  + comboItems.Category + "\t"
                                                                + comboItems.Price);

                    }

                }

            }

            catch
            {
                throw new Exception("Input Error");
            }


        }

    }
}
