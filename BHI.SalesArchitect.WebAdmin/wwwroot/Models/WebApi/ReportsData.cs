using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "ReportsData")]
    public class ReportsData
    {
        [DataMember(Name = "ProspectsReportData")]
        public List<RegisterCountForReport> ProspectsReportData { get; set; }
        [DataMember(Name = "SalesUserPerformanceData")]
        public List<SalesUserGeneratedLeadsCount> SalesUserPerformanceData { get; set; }
        [DataMember(Name = "SalesUserAppUsageTimeData")]
        public List<SalesUsersAverageUsageTime> SalesUserAppUsageTimeData { get; set; }
    }
}