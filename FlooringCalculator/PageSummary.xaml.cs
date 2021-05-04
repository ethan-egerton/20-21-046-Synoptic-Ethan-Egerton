using System.Windows;
using System.Windows.Controls;
using FlooringCalculator.Models;

/* Title: PageSummary
 * Author: Ethan Egerton
 * Date: Feburary 2021
 * Purpose: Logic for the PageSummary page
 */

namespace FlooringCalculator
{
    // Interaction logic for PageSummary
    public partial class PageSummary : Page
    {
        // Calling the class DataSummary
        DataSummary dataSummary = new DataSummary();

        // Calls one method on startup and sets the text of the text box to the
        // result of the calculations.
        public PageSummary(DataSummary summary)
        {
            InitializeComponent();
            dataSummary = summary;
            HelpTextBox.Text = dataSummary.SummaryForDisplay();
        }

        // When the BackButton button is clicked, the user will be sent to the data
        // entry page.
        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            var pageDataEntry = new PageDataEntry();
            var navigationService = NavigationService;
            if (navigationService != null) navigationService.Navigate(pageDataEntry);
        }

        // When the ExitButton button is clicked, the application will shutdown
        private void ExitButton_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
