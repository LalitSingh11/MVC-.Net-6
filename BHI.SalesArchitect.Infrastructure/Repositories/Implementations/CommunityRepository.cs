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
        public CommunityRepository(SalesArchitectContext db)
        { 
            _dbContext = db;
        }

        public IEnumerable<Community> GetByCommunityIDs(List<int> communityIDs)
        {
            return _dbContext.Communities.Where(x => communityIDs.Contains(x.Id)).ToList();
        }

        /*public IEnumerable<Community> GetCommunityListByPartnerId(int partnerId)
        {
            var result = from c in _dbContext.Communities
                        join pc in _dbContext.PartnerCommunities on c.Id equals pc.CommunityId
                        where pc.PartnerId == partnerId
                        select c;
            return result;
        }*/

        public IEnumerable<GridCommunityResult> GetProcDataByPartnerId(int partnerID)
        {
            string commandText = "EXEC pr_GetCommunityList @partnerId";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@partnerID", SqlDbType.Int)
            {
                Value = partnerID
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
                    /*using (var dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var comm = new GridCommunityModel()
                                {
                                    Name = dataReader[11].ToString(),
                                    VendorReference = dataReader["VendorReference"].ToString(),
                                    Id = int.Parse(dataReader[6].ToString()),
                                    Bdxid = int.Parse(dataReader[7].ToString()),
                                    Dwstatus = int.TryParse(dataReader[8].ToString(), out var dwStatus) ? dwStatus : null,
                                    MarketId = int.Parse(dataReader["MarketID"].ToString()),
                                    MarketName = dataReader[2].ToString(),
                                    Ispname = dataReader["ISPName"].ToString(),
                                    ActivityStateId = int.Parse(dataReader["ActivityStateID"].ToString()),
                                    Admins = dataReader[12].ToString(),
                                    Locked = (bool)dataReader["Locked"],
                                    PreferredCommunityAssetId = int.TryParse(dataReader["ActivityStateID"].ToString(), out var preferredId) ? preferredId : null,
                                    NewIsp = dataReader["NewIsp"].GetType().Name != "DBNull" && (bool)dataReader[16],
                                    Status = (bool)dataReader["Status"],
                                    Brand = dataReader["Brand"].ToString(),
                                    LotCount = int.Parse(dataReader["LotCount"].ToString()),
                                    ProspectCount = int.Parse(dataReader["ProspectCount"].ToString()),
                                    DateDeleted = DateTime.TryParse(dataReader["DateDeleted"].ToString(), out DateTime result) ? result : null,
                                    DeletedBy = dataReader["DeletedBy"].ToString()
                                }; 
                            }
                        }
                    }*/
                             
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
                                    MarketId = int.Parse(dataReader["MarketID"].ToString()),
                                    MarketName = dataReader[2].ToString(),
                                    Ispname = dataReader["ISPName"].ToString(),
                                    ActivityStateId = int.Parse(dataReader["ActivityStateID"].ToString()),
                                    Admins = dataReader[12].ToString(),
                                    Locked = (bool)dataReader["Locked"],
                                    PreferredCommunityAssetId = int.TryParse(dataReader["ActivityStateID"].ToString(), out var preferredId) ? preferredId : null,
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
