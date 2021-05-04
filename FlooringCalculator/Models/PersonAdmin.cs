using System.Text;

/* Title: PersonAdmin
 * Author: Ethan Egerton
 * Date: Feburary 2021
 * Purpose: Class inherited from person, holds admin data
 */

namespace FlooringCalculator.Models
{
    public class PersonAdmin : Person
    {
        // Public
        public string Department { get; set; }
        
        public override string GetDetails()
        {
            string baseDetails = base.GetDetails();

            StringBuilder stringBuilder = new StringBuilder();
            var sb = stringBuilder;
            sb.Append(baseDetails).AppendLine();
            sb.Append("Works in: ").AppendLine(Department);
            sb.AppendLine();

            return sb.ToString();
        }
    }
}