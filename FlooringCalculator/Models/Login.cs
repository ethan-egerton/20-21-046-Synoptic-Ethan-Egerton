using System;
using System.Collections.Generic;
using System.Text;

/* Title: Login
 * Author: Ethan Egerton
 * Date: Feburary 2021
 * Purpose: Prototype Authentication 
 */

namespace FlooringCalculator.Models
{
    public class Login
    {
        public static bool Validate(string username, string password)
        {
            var validity = false;
            var debugUsername = "samhen33";
            var debugPassword = "testpassword";

            try
            {
                validity = (username == debugUsername) && (password == debugPassword);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return validity;
        }
    }
}
