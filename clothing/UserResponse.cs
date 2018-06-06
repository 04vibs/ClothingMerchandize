using System;
using System.Collections.Generic;
using System.Text;

namespace clothing
{
    class UserResponse
    {
        /// <summary>
        /// Get the user Response
        /// </summary>
        /// <returns> userResponse</returns>
        //Static method just to avoid making its object
        public static char Response()
        {

            Char userAns = Convert.ToChar(Console.ReadLine());
            return userAns;

        }
    }
}
