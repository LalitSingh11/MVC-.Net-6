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

        public async Task<bool> AddUser(User user)
        {
            _dbContext.Users.Add(user);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteUser(User user)
        {
            _dbContext.Users.Remove(user);
            return await _dbContext.SaveChangesAsync() > 0;
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

        public async Task<bool> UpdateUser(User user)
        {
            _dbContext.Users.Update(user);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<User>> GetByPartnerIdAndCommunityUser(int partnerId, int userId, List<int> roleIds, int activityStateId)
        {
            //review the query in future missing left join
            var result  = from u in _dbContext.Users
                                     join acts in _dbContext.ActivityStates on u.ActivityStateId equals acts.Id
                                     join cu in _dbContext.CommunityUsers on u.Id equals cu.UserId 
                                     join cuu in _dbContext.CommunityUsers on cu.CommunityId equals cuu.UserId
                                     join ur in _dbContext.UserRoles on u.Id equals ur.UserId
                                     where !roleIds.Contains(ur.RoleId)
                                           && u.PartnerId == partnerId
                                           && (cuu == null || cuu.UserId == userId || u.ActivityStateId == activityStateId)
                                     select u;

            return await result.Distinct().ToListAsync();
        }

        public async Task<IEnumerable<User>> GetByPartnerIdExcludingRoles(int partnerId, List<int> roleIds)
        {
            var result = from u in _dbContext.Users
                         join acts in _dbContext.ActivityStates on u.ActivityStateId equals acts.Id
                         join ur in _dbContext.UserRoles on u.Id equals ur.UserId
                         where u.PartnerId == partnerId && !roleIds.Contains(ur.RoleId)
                         select u;
            return await result.ToListAsync();
        }

        public async Task<IEnumerable<User>> GetCommunityAdminsByCommunityID(List<int> communityIDs)
        {
            int communityRole = _roleRepository.PartnerAdmin.Id;
            var query = from u in _dbContext.Users
                        join acts in _dbContext.ActivityStates on u.ActivityStateId equals acts.Id
                        join cu in _dbContext.CommunityUsers on u.Id equals cu.UserId
                        join ur in _dbContext.UserRoles on new { UserId = u.Id, RoleId = communityRole } equals new { ur.UserId, ur.RoleId }
                        where communityIDs.Contains(cu.CommunityId)
                        select u;
            return await query.Distinct().ToListAsync();
        }

        public async Task<IEnumerable<User>> GetSuperUsers()
        {
            var query = from u in _dbContext.Users
                        join acts in _dbContext.ActivityStates on u.ActivityStateId equals acts.Id
                        join ur in _dbContext.UserRoles on u.Id equals ur.UserId
                        where ur.RoleId == _roleRepository.PartnerSuperAdmin.Id || ur.RoleId == _roleRepository.BHIAdmin.Id
                        select u;
            return await query.ToListAsync();
        }

      
    }
}
