using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHI.SalesArchitect.WebAdmin.Models
{
    public class LotStatusTranslator
    {
        public static string GetColorCode(string code)
        {
            switch (code)
            {
                case "AVAILABLE":
                    return "SPSTSCLR_Available";
                case "CONPENDING":
                    return "SPSTSCLR_Contract Pending";
                case "HOMEAVAILABLE":
                    return "SPSTSCLR_Home Available";
                case "SOLD":
                    return "SPSTSCLR_SOLD";
                case "FUTUREPHASE":
                    return "SPSTSCLR_Future Phase";
                case "MARKET":
                    return "SPSTSCLR_MARKET";
                case "RESERVED":
                    return "SPSTSCLR_RESERVED";
                case "MODEL":
                    return "SPSTSCLR_MODEL";
                default:
                    return string.Format("SPSTSCLR_{0}", code);
            }
        }
    }
}
