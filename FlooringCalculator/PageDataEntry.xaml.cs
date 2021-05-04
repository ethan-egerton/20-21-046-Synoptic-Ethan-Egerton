using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using FlooringCalculator.Models;

/* Title: PageDataEntry
 * Author: Ethan Egerton
 * Date: Feburary 2021
 * Purpose: Logic for the PageDataEntry page
 */

namespace FlooringCalculator
{
    // Interaction logic for PageDataEntry
    public partial class PageDataEntry : Page
    {
        // Variables to store data from the module
        private string selectedTileName = string.Empty;
        private Room room = new Room();
        private Tile tile = new Tile();
        private DataSummary dataSummary = new DataSummary();

        // Calls two methods on startup
        public PageDataEntry()
        {
            InitializeComponent();
            AssignmentRoomData();
        }

        // Fills the text boxes with sample text
        private void AssignmentRoomData()
        {
            RoomWideATextBox.Text = "6.50";
            RoomLongBTextBox.Text = "7.20";
            Cutout1WideCTextBox.Text = "1.60";
            Cutout1LongDTextBox.Text = "2.30";
            Cutout2WideETextBox.Text = "0.6";
            Cutout2LongFTextBox.Text = "0.3";
        }

        // Clears the text boxes when the ClearButton button is clicked
        private void ClearButton_OnClick(object sender, RoutedEventArgs e)
        {
            ResetControls();
        }

        // Performs calculations, sets results as data for next page, navigates to next page 
        private void CalculateButton_OnClick (object sender, RoutedEventArgs e)
        {
            try
            {
                var controlData = false;

                controlData = ControlHasValueCheck();

                if (controlData)
                {
                    // Get base data needed for room and tile
                    tile = GetSelectedTile();
                    room = HarvestData();

                    // create a DataSummary object to hold calculation outcomes
                    // This object will be passed to the PageSummary page
                    // and then displayed in the TextBlock

                    var dataForSummary = new DataSummary()
                    {
                        WholeRoomArea = RoomAreas.WholeRoomArea(room).ToString(),
                        Cutout1Area = RoomAreas.AreaCutout1(room).ToString(),
                        Cutout2Area = RoomAreas.AreaCutout2(room).ToString(),
                        TileSizeUsed = selectedTileName,
                        TilesNeededForRoom = Calculator.NumberTilesForFloor(room, tile).ToString(),
                        LeftoverTileArea = Calculator.AreaLeftoverTile(room, tile).ToString(),
                        PerimeterLength = RoomAreas.RoomPerimeter(room).ToString()
                    };

                    dataSummary = dataForSummary;

                    // Navigate to PageSummary with the dataSummary object
                    var pageSummary = new PageSummary(dataSummary);
                    var navigationService = NavigationService;
                    if (navigationService != null) navigationService.Navigate(pageSummary);
                }
                // If data is missing, then this box will pop up
                else
                {
                    MessageBox.Show("Some data is missing. Please check");
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        // Loads the values for TileComboBox and selects the first value on load
        private void TileComboBox_OnLoaded(object sender, RoutedEventArgs e)
            {
                var combo = (ComboBox)sender;
                if (combo == null) return;
                combo.ItemsSource = Tiles();
                combo.SelectedIndex = 0;
        }

        // When TileComboBox combo box is changed, the value of selectedTileName
        // is change to the selected value.
        private void TileComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;

            try
            {
                if (combo != null) selectedTileName = combo.SelectedItem.ToString();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        // Navigates to help page
        private void LaunchHelpButton_OnClick(object sender, RoutedEventArgs e)
        {
            var pageHelp = new PageHelp();
            if (NavigationService != null) NavigationService.Navigate(pageHelp);
        }

        // List for combo box
        private List<string> Tiles()
        {
            List<string> tiles = new List<string>();
            tiles.Add("60 x 60");
            tiles.Add("75 x 75");

            return tiles;
        }

        // Clears the text boxes
        private void ResetControls()
        {
            RoomWideATextBox.Text = "0";
            RoomLongBTextBox.Text = "0";
            Cutout1WideCTextBox.Text = "0";
            Cutout1LongDTextBox.Text = "0";
            Cutout2WideETextBox.Text = "0";
            Cutout2LongFTextBox.Text = "0";
        }

        // Returns values for tile calculatons based on which tile the user selected
        private Tile GetSelectedTile()
        {
            var tempTile = new Tile();

            switch (selectedTileName)
            {
                case "60 x 60":
                    tempTile.TileWide = 0.60m;
                    tempTile.TileLong = 0.60m;
                    break;
                case "75 x 75":
                    tempTile.TileWide = 0.75m;
                    tempTile.TileLong = 0.75m;
                    break;
                default:
                    tempTile.TileWide = 1;
                    tempTile.TileLong = 1;
                    break;
            }
            return tempTile;
        }

        // Checks if any of the text boxes are empty
        private bool ControlHasValueCheck()
        {
            return !string.IsNullOrEmpty(RoomWideATextBox.Text) &&
                   !string.IsNullOrEmpty(RoomLongBTextBox.Text) &&
                   !string.IsNullOrEmpty(Cutout1WideCTextBox.Text) &&
                   !string.IsNullOrEmpty(Cutout1LongDTextBox.Text) &&
                   !string.IsNullOrEmpty(Cutout2WideETextBox.Text) &&
                   !string.IsNullOrEmpty(Cutout2LongFTextBox.Text);
        }

        // takes data and sets them into the room class
        private Room HarvestData()
        {
            try
            {
                // Takes data from text boxes and casts/parses them into floats
                decimal roomWide = decimal.Parse(RoomWideATextBox.Text);
                decimal roomLong = decimal.Parse(RoomLongBTextBox.Text);
                decimal cutout1WideC = decimal.Parse(Cutout1WideCTextBox.Text);
                decimal cutout1LongD = decimal.Parse(Cutout1LongDTextBox.Text);
                decimal cutout2WideE = decimal.Parse(Cutout2WideETextBox.Text);
                decimal cutout2LongF = decimal.Parse(Cutout2LongFTextBox.Text);

                // Sets the values of the room class to the parsed data.
                var tempRoom = new Room()
                {
                    RoomWide = roomWide,
                    RoomLong = roomLong,
                    Cutout1Wide = cutout1WideC,
                    Cutout1Long = cutout1LongD,
                    Cutout2Wide = cutout2WideE,
                    Cutout2Long = cutout2LongF
                };

                return tempRoom;
            }
            // Writes an error into the console
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}