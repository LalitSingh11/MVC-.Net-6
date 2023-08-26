using BHI.SalesArchitect.Model.DB;
using Microsoft.EntityFrameworkCore;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class CustomizedLocationRepository : ICustomizedLocationRepository
    {
        private SalesArchitectContext _dbContext;
        public CustomizedLocationRepository(SalesArchitectContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<CustomizedLocation>> GetAll()
        {
            return await _dbContext.CustomizedLocations.ToListAsync();
        }
    }
}
