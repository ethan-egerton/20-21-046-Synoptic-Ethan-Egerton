using System;
using System.Collections.Generic;
using System.Text;

/* Title: RoomAreas
 * Author: Ethan Egerton
 * Date: Feburary 2021
 * Purpose: Class for holding methods for calculations
 */


namespace FlooringCalculator.Models
{
    public class RoomAreas
    {
        // Private
        private decimal areaCutoutOne;

        private decimal areaCutoutTwo;

        // Protected Method
        protected void Cutout1Area(Room room)
        {
            areaCutoutOne = room.Cutout1Wide * room.Cutout1Long;
        }

        protected void Cutout2Area(Room room)
        {
            areaCutoutOne = room.Cutout2Wide * room.Cutout2Long;
        }

        // Public
        public decimal AreaCutoutOne
        {
            get => areaCutoutOne;
            set => areaCutoutOne = value;
        }

        public decimal AreaCutoutTwo
        {
            get => areaCutoutTwo;
            set => areaCutoutTwo = value;
        }

        // Public Methods

        public static decimal RoomPerimeter(Room room)
        {
            return (room.RoomWide * 2 + room.RoomLong * 2) - (room.Cutout1Wide + room.Cutout1Long + room.Cutout2Wide + room.Cutout2Long);
        }

        public static decimal AreaCutout1(Room room)
        {
            return room.Cutout1Wide * room.Cutout1Long;
        }

        public static decimal AreaCutout2(Room room)
        {
            return room.Cutout2Wide * room.Cutout2Long;
        }

        public static decimal WholeAreaCutouts (Room room)
        {
            var areaOne = room.Cutout1Wide * room.Cutout1Long;
            var areaTwo = room.Cutout2Wide * room.Cutout2Long;

            return areaOne + areaTwo;
        }

        public static decimal WholeRoomArea(Room room)
        {
            return room.RoomWide * room.RoomLong;
        }
    }
}
