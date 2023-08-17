using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class RoleRepository : IRoleRepository
    {
        private SalesArchitectContext _dbContext;
        public RoleRepository(SalesArchitectContext dbContext)
        {
            _dbContext = dbContext; 
            Initialize();
        }
        public Role BHIAdmin { get; set; }
        public Role PartnerAdmin { get; set; }
        public Role PartnerReadOnly { get; set; }
        public Role PartnerSuperAdmin { get; set; }
        public Role LotStatusEditor { get; set; }

        public IEnumerable<Role> GetAll()
        {
            return _dbContext.Roles.ToList();
        }

        public Role GetByCode(string code)
        {
            return _dbContext.Roles.Where(x => x.Code ==  code).FirstOrDefault();
        }

        public Role GetByUserId(int userId)
        {
            var query = from r in _dbContext.Roles
                        join ur in _dbContext.UserRoles on r.Id equals ur.RoleId
                        join u in _dbContext.Users on ur.UserId equals u.Id
                        where u.Id == userId
                        select r;
            return query.FirstOrDefault();
        }

        public Role GetByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        private void Initialize()
        {
            var roles = GetAll();

            BHIAdmin = roles.FirstOrDefault(p => p.Code == "BHIADMIN");
            PartnerAdmin = roles.FirstOrDefault(p => p.Code == "PARTNERADMIN");
            PartnerReadOnly = roles.FirstOrDefault(p => p.Code == "PARTNERREADONLY");
            PartnerSuperAdmin = roles.FirstOrDefault(p => p.Code == "PARTNERSUPERADMIN");
            LotStatusEditor = roles.FirstOrDefault(p => p.Code == "LOTSTATUSEDITOR");
        }
    }
}
