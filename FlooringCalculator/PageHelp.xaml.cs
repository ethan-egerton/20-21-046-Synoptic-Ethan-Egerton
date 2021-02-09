using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/* Title: PageHelp
 * Author: Ethan Egerton
 * Date: Feburary 2021
 * Purpose: Logic for the PageHelp page
 */

namespace FlooringCalculator
{
    /// <summary>
    /// Interaction logic for PageHelp.xaml
    /// </summary>
    public partial class PageHelp : Page
    {
        public PageHelp()
        {
            InitializeComponent();
            HelpTextBlock.Text = HelpText();
        }

        private void CloseButton_OnClick(object sender, RoutedEventArgs e)
        {
            var pageDataEntry = new PageDataEntry();
            if (NavigationService != null) NavigationService.Navigate(pageDataEntry);
        }

        private string HelpText()
        {
            return "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        }
    }
}
