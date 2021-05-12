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
            return "This application calculates the area of tiles needed on a floor with two cutout rectangeles. To use the aoplication, enter the floors' width and length in to textboxes A and B, then input the the first cutouts' width and length in to textboxes C and D, after that, input the second cutouts' width and length into textboxes E and F, finally select the tile size.\nAfter that press the calculate button and the results will display on the summary page.";
        }
    }
}
