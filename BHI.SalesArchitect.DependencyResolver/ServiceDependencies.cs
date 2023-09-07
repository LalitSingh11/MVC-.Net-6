using Microsoft.Extensions.DependencyInjection;
using BHI.SalesArchitect.Service;
using BHI.SalesArchitect.Service.Implementations;

namespace BHI.SalesArchitect.DependencyResolver
{
    public class ServiceDependencies
    {
        public ServiceDependencies(IServiceCollection services)
        {
            services.AddScoped<IActivityStateService, ActivityStateService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IBuilderBrandService, BuilderBrandService>();
            services.AddScoped<ICommunityService, CommunityService>();
            services.AddScoped<ICommunitySiteService, CommunitySiteService>();
            services.AddScoped<ICommunityUserService, CommunityUserService>();
            services.AddScoped<ICommunitySiteGeoJsonService, CommunitySiteGeoJsonService>();
            services.AddScoped<IConfigurationService, ConfigurationService>();
            services.AddScoped<ICustomizedContentService, CustomizedContentService>();
            services.AddScoped<IListingService, ListingService>();
            services.AddScoped<ILotListingService, LotListingService>();
            services.AddScoped<ILotService, LotService>();
            services.AddScoped<ILotStateService, LotStateService>();
            services.AddScoped<IMasterPlanService, MasterPlanService>();
            services.AddScoped<IPartnerService, PartnerService>();
            services.AddScoped<IProspectConfigurationService, ProspectConfigurationService>();
            services.AddScoped<IProspectCommunityService, ProspectCommunityService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<ISiteService, SiteService>();
            services.AddScoped<ISessionService, SessionService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRoleService, UserRoleService>();
        }
    }
}
