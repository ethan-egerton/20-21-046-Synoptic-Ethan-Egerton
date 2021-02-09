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
    /// <summary>
    /// Interaction logic for PageSummary.xaml
    /// </summary>
    public partial class PageSummary : Page
    {
        DataSummary dataSummary = new DataSummary();

        public PageSummary(DataSummary summary)
        {
            InitializeComponent();
            dataSummary = summary;
            HelpTextBox.Text = dataSummary.SummaryForDisplay();
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            var pageDataEntry = new PageDataEntry();
            var navigationService = NavigationService;
            if (navigationService != null) navigationService.Navigate(pageDataEntry);
        }

        private void ExitButton_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
