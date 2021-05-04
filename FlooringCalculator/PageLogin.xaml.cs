using System;
using System.Windows;
using System.Windows.Controls;
using FlooringCalculator.Models;

/* Title: PageLogin
 * Author: Ethan Egerton
 * Date: Feburary 2021
 * Purpose: Logic for the PageLogin page
 */

namespace FlooringCalculator
{
    // Interaction logic for PageLogin
    public partial class PageLogin : Page
    {
        // Calls two methods on startup
        public PageLogin()
        {
            InitializeComponent();
            FillTempCredentials();
        }

        // Fills the text boxes with sample text
        private void FillTempCredentials()
        {
            this.UsernameTextBox.Text = "samhen33";
            this.PasswordTextBox.Text = "testpassword";
        }

        // Checks to see if the text boxes are empty
        private bool CheckEntries(string username, string password)
        {
            bool valid = !(string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password));

            return valid;
        }

        // Clears the text boxes when the ClearButton button is clicked
        private void ClearButton_OnClick(object sender, RoutedEventArgs e)
        {
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        // Validates credentials and opens next page if credentials are correct
        private void SubmitButton_OnClick(object sender, RoutedEventArgs e)
        {
            // Conditional statement calling the CheckEntries method
            if (CheckEntries(UsernameTextBox.Text, PasswordTextBox.Text))
            {
                try
                {
                    // Conditional statement calling the Validate method from class Login
                    if (Login.Validate(UsernameTextBox.Text, PasswordTextBox.Text))
                    {
                        // Opens PageDataEntry
                        var pageDataEntry = new PageDataEntry();
                        var navigationService = this.NavigationService;
                        navigationService?.Navigate(pageDataEntry);
                    }
                    else
                    {
                        // If credentials are incorrect, this message box will appear
                        MessageBox.Show("Credentials are incorrect. Please re-enter");
                    }
                }
                catch (Exception exception)
                {
                    // If an error occurs, the error is printed to the console
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }
    }
}