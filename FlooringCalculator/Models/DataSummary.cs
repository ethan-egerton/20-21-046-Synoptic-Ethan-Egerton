using System.Text;

/* Title: Data Summary
 * Author: Ethan Egerton
 * Date: Feburary 2021
 * Purpose: Show data for the summary page
 */

namespace FlooringCalculator.Models
{
    public class DataSummary
    {
        // Retreives the calculated data
        public string WholeRoomArea { get; set; }
        public string Cutout1Area { get; set; }
        public string Cutout2Area { get; set; }
        public string TileSizeUsed { get; set; }
        public string TilesNeededForRoom { get; set; }
        public string LeftoverTileArea { get; set; }
        public string PerimeterLength { get; set; }
        
        // Creates string for outputting the calculated data
        public string SummaryForDisplay()
        {
            var sb = new StringBuilder();

            sb.Append("Whole Room Area: ").Append(WholeRoomArea).Append(" M²").AppendLine();
            sb.Append("Cutout 1 Area: ").Append(Cutout1Area).Append(" M²").AppendLine();
            sb.Append("Cutout 2 Area: ").Append(Cutout2Area).Append(" M²").AppendLine();
            sb.Append("Tile size calculated: ").Append(TileSizeUsed).AppendLine();
            sb.Append("Tiles needed for room: ").Append(TilesNeededForRoom).AppendLine();
            sb.Append("Area of tile left over: ").Append(LeftoverTileArea).Append(" M²").AppendLine();
            sb.Append("Edging strip needed: ").Append(PerimeterLength).Append(" M").AppendLine();

            return sb.ToString();
        }
    }
}
