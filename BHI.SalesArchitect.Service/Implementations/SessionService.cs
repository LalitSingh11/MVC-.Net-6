using Microsoft.AspNetCore.Http;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class SessionService : ISessionService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;

        public SessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public int? UserID
        {
            get { return _session.GetInt32("UserId"); }
            set { _session.SetInt32("UserID", (int)value); }
        }

        public int? PartnerID
        {
            get { return _session.GetInt32("PartnerID"); }
            set { _session.SetInt32("PartnerID", (int)value); }
        }

        public int? CommunityID
        {
            get { return _session.GetInt32("CommunityID"); }
            set { _session.SetInt32("CommunityID", (int)value); }
        }

        public string PartnerName
        {
            get { return _session.GetString("PartnerName"); }
            set { _session.SetString("PartnerName", value); }
        }

        public string PartnerDataKey
        {
            get { return _session.GetString("PartnerDataKey"); }
            set { _session.SetString("PartnerDataKey", value); }
        }

        public bool IsIsp
        {
            get { return Convert.ToBoolean(_session.GetString("IsIsp")); }
            set { _session.SetString("PartnerDataKey", value.ToString()); }
        }
    }
}