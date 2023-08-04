using Microsoft.Extensions.DependencyInjection;
using BHI.SalesArchitect.Service;
using BHI.SalesArchitect.Service.Implementations;

namespace BHI.SalesArchitect.DependencyResolver
{
    public class ServiceDependencies
    {
        public ServiceDependencies(IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ICommunityService, CommunityService>();
            services.AddScoped<ICommunitySiteService, CommunitySiteService>();
            services.AddScoped<ICommunityUserService, CommunityUserService>();
            services.AddScoped<ISessionService, SessionService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICommunitySiteGeoJsonService, CommunitySiteGeoJsonService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IMasterPlanService, MasterPlanService>();
            services.AddScoped<ISiteService, SiteService>();
            services.AddScoped<IPartnerService, PartnerService>();
            services.AddScoped<IProspectConfigurationService, ProspectConfigurationService>();
        }
    }
}
