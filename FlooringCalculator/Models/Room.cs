/* Title: Room
 * Author: Ethan Egerton
 * Date: Feburary 2021
 * Purpose: Class for handling room dimension data
 */


namespace FlooringCalculator.Models
{
    public class Room
    {
        // Private
        private decimal cutout1Wide;

        private decimal cutout1Long;

        private decimal cutout2Wide;

        private decimal cutout2Long;


        // Public
        public decimal RoomWide { get; set; }

        public decimal RoomLong { get; set; }

        public decimal Cutout1Wide
        {
            get => cutout1Wide;
            set => cutout1Wide = value;
        }

        public decimal Cutout1Long
        {
            get => cutout1Long;
            set => cutout1Long = value;
        }

        public decimal Cutout2Wide
        {
            get => cutout2Wide;
            set => cutout2Wide = value;
        }

        public decimal Cutout2Long
        {
            get => cutout2Long;
            set => cutout2Long = value;
        }
    }
}