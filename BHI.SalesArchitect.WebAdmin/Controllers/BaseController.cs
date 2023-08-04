using BHI.SalesArchitect.Service;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BHI.SalesArchitect.WebAdmin.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {            
        }

        public int UserId
        {
            get { return GetUserId(); }
        }
        public string UserName
        {
            get { return GetUserName(); }
        }
        public string UserRole
        {
            get { return GetUserRole(); }
        }
        public int PartnerId
        {
            get { return GetPartnerId(); }
        }
        public string PartnerName
        {
            get { return GetPartnerName(); }
        }public string PartnerDataKey
        {
            get { return GetPartnerDataKey(); }
        }

        #region Private Methods
        private int GetUserId()
        {
            var UserID = User.Claims.Where(x => x.Type == "UserId").Select(x => x.Value).FirstOrDefault();
            return int.Parse(UserID);
        }
        private string GetUserName()
        {
            var UserName = User.Claims.Where(x => x.Type == ClaimTypes.Name).Select(x => x.Value).FirstOrDefault();
            return UserName;
        }
        private string GetUserRole()
        {
            var UserRole = User.Claims.Where(x => x.Type == ClaimTypes.Role).Select(x => x.Value).FirstOrDefault();
            return UserRole;
        }
        private int GetPartnerId()
        {
            var partnerID = User.Claims.Where(x => x.Type == "PartnerId").Select(x => x.Value).FirstOrDefault();
            return int.Parse(partnerID);
        }
        private string GetPartnerName()
        {
            var partnerName = User.Claims.Where(x => x.Type == "PartnerName").Select(x => x.Value).FirstOrDefault();
            return partnerName;
        }
        private string GetPartnerDataKey()
        {
            var partnerKey = User.Claims.Where(x => x.Type == "PartnerDataKey").Select(x => x.Value).FirstOrDefault();
            return partnerKey;
        }
        #endregion
    }
}
