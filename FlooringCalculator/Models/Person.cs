using System;
using System.Collections.Generic;
using System.Text;

/* Title: Person
 * Author: Ethan Egerton
 * Date: Feburary 2021
 * Purpose: Holds data about person
 */

namespace FlooringCalculator.Models
{
    public class Person
    {
        // Private
        private string personForename;
        private string personSurname;

        // Public
        public string PersonForename
        {
            get => personForename;
            set => personForename = value;
        }

        public string PersonSurname
        {
            get => personSurname;
            set => personSurname = value;
        }

        // -- Concatenates forename and surname
        public static string PersonWholeNameByForename(Person person)
        {
            return person.personForename + " " + person.personSurname;
        }

        // -- Concatenates surname and forename
        public static string PersonWholeNameBySurname(Person person)
        {
            return person.personSurname + " " + person.personForename;
        }

        // -- method to be overridden, returns the same result as PersonWholeNameByForename
        public virtual string GetDetails()
        {
            StringBuilder stringBuilder = new StringBuilder();
            var sb = stringBuilder;
            sb.Append(personForename).Append(" ").Append(personSurname);

            return sb.ToString();
        }
    }
}
