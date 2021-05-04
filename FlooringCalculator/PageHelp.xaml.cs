using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

/* Title: PageHelp
 * Author: Ethan Egerton
 * Date: Feburary 2021
 * Purpose: Logic for the PageHelp page
 */

namespace FlooringCalculator
{
    // Interaction logic for PageHelp
    public partial class PageHelp : Page
    {
        // Calls one method on startup and fills the text box with lorem ipsum.
        // The lorem ipsum is a temporary text that will be replaced with actual 
        // help when the real application is developed.
        public PageHelp()
        {
            InitializeComponent();
            HelpTextBlock.Text = HelpText();
        }

        // Navigates back to the data entry page when the CloseButton button is pressed
        private void CloseButton_OnClick(object sender, RoutedEventArgs e)
        {
            var pageDataEntry = new PageDataEntry();
            if (NavigationService != null) NavigationService.Navigate(pageDataEntry);
        }

        // Text box is filled with lorem ipsum text
        private string HelpText()
        {
            return "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        }
    }
}
