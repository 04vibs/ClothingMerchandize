using System;
using System.Collections.Generic;
using System.Text;

namespace clothing
{
    /// <summary>
    /// Generate Random Number 
    /// according to Random Number 
    /// it displays the weather Message
   /// </summary>
    class Weather
    {
        //Constants cs = new Constants();
        Random rn = new Random();
         private static int RandomNumber = -1;

        public string TodayWeather()
        {
            if (Weather.RandomNumber == -1)
            {
                Weather.RandomNumber = rn.Next(0, 3);
            }
            return (Constants.weather[Weather.RandomNumber]);

        }
        public string Message()
        {
            return (Constants.Message[Weather.RandomNumber]);
        }
    }
}
