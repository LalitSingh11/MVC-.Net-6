using BHI.SalesArchitect.Model.DB;
using Microsoft.EntityFrameworkCore;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class CustomizedContentTypeRepository : ICustomizedContentTypeRepository
    {
        private SalesArchitectContext _dbContext;
        public CustomizedContentTypeRepository(SalesArchitectContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<CustomizedContentType>> GetAll()
        {
            return await _dbContext.CustomizedContentTypes.ToListAsync();
        }
    }
}
