using BHI.SalesArchitect.Model;
using BHI.SalesArchitect.Model.DB;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class CommunityRepository : ICommunityRepository
    {
        private SalesArchitectContext _dbContext;
        public CommunityRepository(SalesArchitectContext dbContext)
        { 
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Community>> GetActiveCommunitiesByCommunityIds(List<int> communityIds)
        {
            var result = from c in _dbContext.Communities
                         join pc in _dbContext.PartnerCommunities on c.Id equals pc.CommunityId
                         where communityIds.Contains(c.Id)
                         select c;
            return await result.ToListAsync();
        }

        public Task<Community> GetByCommunityId(int communityId)
        {
            var result = from c in _dbContext.Communities
                        join m in _dbContext.Markets on c.MarketId equals m.Id
                        join acts in _dbContext.ActivityStates on c.ActivityStateId equals acts.Id
                        where c.Id == communityId
                        select c;
            return result.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Community>> GetByCommunityIds(List<int> communityIds)
        {
            var result = from c in _dbContext.Communities
                        join m in _dbContext.Markets on c.MarketId equals m.Id
                        join acts in _dbContext.ActivityStates on c.ActivityStateId equals acts.Id
                        where communityIds.Contains(c.Id)
                        select c;
            return await result.ToListAsync();
        }

        public async Task<IEnumerable<Community>> GetByPartnerIdAndByUserId(int partnerId, int userId)
        {
            var result = from c in _dbContext.Communities
                         join pc in _dbContext.PartnerCommunities on c.Id equals pc.CommunityId
                         join cu in _dbContext.CommunityUsers on c.Id equals cu.CommunityId
                         where pc.PartnerId == partnerId && cu.UserId == userId
                         select c;
            return await result.ToListAsync();
        }

        public async Task<IEnumerable<Community>> GetBySiteIds(List<int> siteIds)
        {
            var result = from c in _dbContext.Communities
                         join cs in _dbContext.CommunitySites on c.Id equals cs.CommunityId
                         join pc in _dbContext.PartnerCommunities on c.Id equals pc.CommunityId
                         where siteIds.Contains(cs.SiteId)
                         select c;
            return await result.ToListAsync();
        }

        public async Task<IEnumerable<Community>> GetCommunitiesByPartnerId(int partnerId)
        {
            var result = from c in _dbContext.Communities
                         join m in _dbContext.Markets on c.MarketId equals m.Id
                         join acts in _dbContext.ActivityStates on c.ActivityStateId equals acts.Id
                         join pc in _dbContext.PartnerCommunities on c.Id equals pc.CommunityId
                         where pc.PartnerId == partnerId
                         select c;
            return await result.ToListAsync();
        }

        public IEnumerable<GridCommunityResult> GetProcDataByPartnerId(int partnerId)
        {
            string commandText = "EXEC pr_GetCommunityList @partnerId";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@partnerId", SqlDbType.Int)
            {
                Value = partnerId
            };
            return CallProc(commandText, parameters);
        }

        private IEnumerable<GridCommunityResult> CallProc(string commandText, params SqlParameter[] parameters)
        {
            var connection = _dbContext.Database.GetDbConnection();
            if (connection.State != ConnectionState.Open)
                connection.Open();
            var communities = new List<GridCommunityResult>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = commandText;
                command.Connection = connection;
                if (parameters?.Length > 0)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                try
                {  
                    using (var dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {

                            while (dataReader.Read())
                            {
                                var comm = new GridCommunityResult()
                                {
                                    Name = dataReader[11].ToString(),
                                    VendorReference = dataReader["VendorReference"].ToString(),
                                    Id = int.Parse(dataReader[6].ToString()),
                                    Bdxid = int.Parse(dataReader[7].ToString()),
                                    Dwstatus = int.TryParse(dataReader[8].ToString(), out var dwStatus) ? dwStatus : null,
                                    MarketId = int.Parse(dataReader["MarketId"].ToString()),
                                    MarketName = dataReader[2].ToString(),
                                    Ispname = dataReader["ISPName"].ToString(),
                                    ActivityStateId = int.Parse(dataReader["ActivityStateId"].ToString()),
                                    Admins = dataReader[12].ToString(),
                                    Locked = (bool)dataReader["Locked"],
                                    PreferredCommunityAssetId = int.TryParse(dataReader["ActivityStateId"].ToString(), out var preferredId) ? preferredId : null,
                                    NewIsp = dataReader["NewIsp"].GetType().Name != "DBNull" && (bool)dataReader[16],
                                    Status = (bool)dataReader["Status"],
                                    Brand = dataReader["Brand"].ToString(),
                                    LotCount = int.Parse(dataReader["LotCount"].ToString()),
                                    ProspectCount = int.Parse(dataReader["ProspectCount"].ToString()),
                                    DateDeleted = DateTime.TryParse(dataReader["DateDeleted"].ToString(), out DateTime result) ? result : null,
                                    DeletedBy = dataReader["DeletedBy"].ToString()
                                };

                                communities.Add(comm); 
                            }
                        }
                    }
                }
                catch (SqlException sqx)
                {
                    if (sqx.Message == "No Community data found for partner")
                        communities = null;
                    else
                        throw sqx;
                }
            }
            return communities;
        }
    }
}
