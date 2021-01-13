using System;
using System.Collections.Generic;
using System.Text;

/* Title: Tile
 * Author: Ethan Egerton
 * Date: Feburary 2021
 * Purpose: Class to handle tile data
 */


namespace FlooringCalculator.Models
{
    public class Tile
    {
        // Private
        private decimal tileWide;
        private decimal tileLong;
        private decimal tileName;

        // Public
        public decimal TileWide
        {
            get => tileWide;
            set => tileWide = value;
        }

        public decimal TileLong
        {
            get => tileLong;
            set => tileLong = value;
        }

        public decimal TileName
        {
            get => tileName;
            set => tileName = value;
        }

        // -- Calculates the area of a tile
        public static decimal TileArea(Tile tile)
        {
            return tile.tileLong * tile.tileWide;
        }
    }
}
