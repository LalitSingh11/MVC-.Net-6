using BHI.SalesArchitect.Model.DB;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly SalesArchitectContext _dbContext;
        private readonly IRoleRepository _roleRepository;
        public UserRepository(SalesArchitectContext db,
            IRoleRepository roleRepository)
        {

            _dbContext = db;
            _roleRepository = roleRepository;
        }
        public async Task<User> GetByEmail(string userEmail)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.Email == userEmail);
        }

        public async Task<User> GetById(int id)
        {
            return await _dbContext.Users.FirstAsync(x => x.Id == id);
        }

        public async Task<User> GetByUserName(string userName)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.UserName == userName);
        }

        public IEnumerable<User> GetCommunityAdminsByCommunityID(List<int> communityIDs)
        {
            int communityRole = _roleRepository.PartnerAdmin.Id;
            var query = from u in _dbContext.Users
                         join acts in _dbContext.ActivityStates on u.ActivityStateId equals acts.Id
                         join cu in _dbContext.CommunityUsers on u.Id equals cu.UserId
                         join ur in _dbContext.UserRoles on new { UserId = u.Id, RoleId = communityRole } equals new { ur.UserId, ur.RoleId }
                         where communityIDs.Contains(cu.CommunityId)
                         select u;
            return query.Distinct();
        }

        public IEnumerable<User> GetSuperUsers()
        {
            var query = from u in _dbContext.Users
                        join acts in _dbContext.ActivityStates on u.ActivityStateId equals acts.Id
                        join ur in _dbContext.UserRoles on u.Id equals ur.UserId
                        where ur.RoleId == _roleRepository.PartnerSuperAdmin.Id || ur.RoleId == _roleRepository.BHIAdmin.Id
                        select u;
            return query;
        }

        public async Task<bool> UpdateUser(User user)
        {
            _dbContext.Users.Update(user);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
