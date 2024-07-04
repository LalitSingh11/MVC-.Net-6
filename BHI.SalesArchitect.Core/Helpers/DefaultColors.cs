namespace BHI.SalesArchitect.Core.Helpers
{
    public class DefaultColors
    {
        public static string GetByCode(string code)
        {
            switch (code)
            {
                case "SPSTSCLR_Available":
                    return "#C1A692";
                case "SPSTSCLR_Contract Pending":
                    return "#00FF00"; //Green
                case "SPSTSCLR_Home Available":
                    return "#0000FF"; //Blue
                case "SPSTSCLR_SOLD":
                    return "#C13925";
                case "SPSTSCLR_Future Phase":
                    return "#ffa500	";  //Orange
                case "SPSTSCLR_MARKET":
                    return "#8B82AC";
                case "SPSTSCLR_Reserved":
                    return "#75180B";
                case "SPSTSCLR_Reservation Pending":
                    return "#c46a5e";
                case "SPSTSCLR_MODEL":
                    return "#3D2E75";
                case "IPADCLR_Top Navigation Bar":
                    return "#ee82ee";//violet
                case "IPADCLR_Side Rail Text":
                    return "#800080";   //purple
                case "IPADCLR_Bottom Toolbar":
                    return "#ffc0cb";//Pink
                case "IPADCLR_Side Rail Background":
                    return "#808080";   //Gray
                case "IPADCLR_Top Navigation Bar Text":
                    return "#87ceeb";   //Skyblue
                case "IPADCLR_Main View Background":
                    return "#ff00ff";   //fucsia
                case "IPADCLR_Button Bar":
                    return "#f0e68c";   //kahki
                case "SMPCLR_Lot Detail Info Bar":
                    return "#c8c8c8";
                case "SMPCLR_Lot Detail Info Bar Gradient":
                    return "#eee";
                case "SMPCLR_Lot Detail Info Bar Text":
                    return "#000";
                default:
                    return "#000000";   //black
            }
        }
    }
}
