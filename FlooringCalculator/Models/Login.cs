using System;

/* Title: Login
 * Author: Ethan Egerton
 * Date: Feburary 2021
 * Purpose: Prototype Authentication 
 */

namespace FlooringCalculator.Models
{
    public class Login
    {
        // Checks whether the user input matches the correct username and password
        // Takes two strings, the username and password harvested from the input boxes
        public static bool Validate(string username, string password)
        {
            // Initisation
            var validity = false;
            // Debug credentials are for testing until a database of credentials is set up
            var debugUsername = "samhen33";
            var debugPassword = "testpassword";

            try
            {
                // Compares the inputted credentials to debug credentials 
                validity = (username == debugUsername) && (password == debugPassword);
            }
            catch (Exception e)
            {
                // If an error occurs, the error is printed to the console
                Console.WriteLine(e);
                throw;
            }

            // Returns boolean as to whether the input was correct
            return validity;
        }
    }
}