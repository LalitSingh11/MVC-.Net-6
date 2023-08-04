using Microsoft.Extensions.DependencyInjection;
using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Infrastructure.Repositories.Implementations;
using BHI.SalesArchitect.Infrastructure;

namespace BHI.SalesArchitect.DependencyResolver
{
    public class RepositoryDependencies
    {
        public RepositoryDependencies(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICommunityRepository, CommunityRepository>();
            services.AddScoped<IPartnerRepository, PartnerRepository>();
            services.AddScoped<ICommunitySiteRepository, CommunitySiteRepository>();
            services.AddScoped<ICommunityUserRepository, CommunityUserRepository>();
            services.AddScoped<ILotRepository, LotRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<ICommunitySiteGeoJsonRepository, CommunitySiteGeoJsonRepository>();
            services.AddScoped<IProspectConfigurationRepository, ProspectConfigurationRepository>();
            services.AddScoped<IMasterPlanRepository, MasterPlanRepository>();
            services.AddScoped<ISiteRepository, SiteRepository>();
        }
    }
}
