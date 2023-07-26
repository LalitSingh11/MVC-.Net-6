using BHI.SalesArchitect.Model.DB;
using Microsoft.EntityFrameworkCore;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    internal class UserRepository : IUserRepository
    {
        private readonly SalesArchitectContext _db;
        public UserRepository(SalesArchitectContext db)
        {

            _db = db;

        }
        public async Task<User> GetByEmail(string userEmail)
        {
            return await _db.Users.FirstOrDefaultAsync(x => x.Email == userEmail);
        }

        public async Task<User> GetByUserName(string userName)
        {
            return await _db.Users.FirstOrDefaultAsync(x => x.UserName == userName);
        }
    }
}
