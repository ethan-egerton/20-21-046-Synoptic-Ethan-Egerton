using System;
using System.Windows;

/* Title: Calculator
 * Author: Ethan Egerton
 * Date: Feburary 2021
 * Purpose: Class for calculations
 */

namespace FlooringCalculator.Models
{
    public class Calculator
    {
        // Calculates the whole amount of tiles on the floor
        public static int NumberTilesWholeFloor(Room room, Tile tile)
        {
            // Initialisation
            int tempTotal = 0;

            // Trys to calculate the quantity of tiles
            try
            {
                var wideQuantity = room.RoomWide / tile.TileWide;
                int wideQuantityUp = Convert.ToInt32(Math.Ceiling(wideQuantity));
                var longQuantity = room.RoomLong / tile.TileLong;
                int longQuantityUp = Convert.ToInt32(Math.Ceiling(longQuantity));

                tempTotal = wideQuantityUp * longQuantityUp;
            }
            // If one of the values in the calculation is 0 then it will throw
            // this error and print it to the console.
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Attempted divide by zero");
                Console.WriteLine("Attempted divide by zero. {0}", ex.Message);
            }

            return tempTotal;
        }

        // Calculates the amount of tiles removed by the cutout
        public static int NumberTilesCutouts (Room room, Tile tile)
        {
            int tempTotal = 0;

            try
            {
                // Cutout 1
                var cutout1WideQuantity = room.Cutout1Wide / tile.TileWide;
                int cutout1WideQuantityDown = Convert.ToInt32(Math.Floor(cutout1WideQuantity));

                var cutout1LongQuantity = room.Cutout1Long / tile.TileLong;
                int cutout1LongQuantityDown = Convert.ToInt32(Math.Floor(cutout1LongQuantity));

                int tilesCutout1 = cutout1LongQuantityDown * cutout1WideQuantityDown;

                // Cutout 2
                var cutout2WideQuantity = room.Cutout2Wide / tile.TileWide;
                int cutout2WideQuantityDown = Convert.ToInt32(Math.Floor(cutout2WideQuantity));

                var cutout2LongQuantity = room.Cutout2Long / tile.TileLong;
                int cutout2LongQuantityDown = Convert.ToInt32(Math.Floor(cutout2LongQuantity));

                int tilesCutout2 = cutout2LongQuantityDown * cutout2WideQuantityDown;

                tempTotal = tilesCutout1 + tilesCutout2;
            }
            // If one of the values in the calculation is 0 then it will throw
            // this error and print it to the console.
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Attempted divide by zero");
                Console.WriteLine("Attempted divide by zero. {0}", ex.Message);
            }

            return tempTotal;
        }

        // Calculates total tiles needed for the floor
        public static int NumberTilesForFloor (Room room, Tile tile)
        {
            int tilesWholeFloor = NumberTilesWholeFloor(room, tile);
            int tilesCutoutAreas = NumberTilesCutouts(room, tile);

            int tilesNeededForFloor = tilesWholeFloor - tilesCutoutAreas;

            return tilesNeededForFloor;
        }

        // Calculates area leftover from cuts
        public static decimal AreaLeftoverTile (Room room, Tile tile)
        {
            decimal tempTotal = 0;

            try
            {
                var wholeRoomArea = RoomAreas.WholeRoomArea(room);
                var oneTileArea = tile.TileLong * tile.TileWide;
                var areaTilesUsed = oneTileArea * NumberTilesWholeFloor(room, tile);
            }
            // If error, error is outputted to console
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return tempTotal;
        }
    }
}