using System.Text;

/* Title: PersonUser
 * Author: Ethan Egerton
 * Date: Feburary 2021
 * Purpose: Class inherited from person, holds user data
 */


namespace FlooringCalculator.Models
{
    public class PersonUser : Person
    {
        // Private
        private string username;
        private string password;

        // Public
        public string MobileNumber { get; set; }
        public string ClientCompany { get; set; }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public override string GetDetails()
        {
            string baseDetails = base.GetDetails();

            StringBuilder stringBuilder = new StringBuilder();
            var sb = stringBuilder;
            sb.Append(baseDetails).AppendLine();
            sb.Append("Mobile Number: ").Append(MobileNumber).AppendLine();
            sb.Append("Company: ").Append(ClientCompany).AppendLine();

            return sb.ToString();
        }

        // -- Test data
        public static PersonUser SampleUser()
        {
            var personUser = new PersonUser
            {
                PersonForename = "Samuel",
                PersonSurname = "Henderson",
                username = "samhen33",
                password = "testpassword",
            };

            return personUser;
        }
    }
}
