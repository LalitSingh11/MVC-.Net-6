﻿using Microsoft.Extensions.DependencyInjection;
using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Infrastructure.Repositories.Implementations;

namespace BHI.SalesArchitect.DependencyResolver
{
    public class RepositoryDependencies
    {
        public RepositoryDependencies(IServiceCollection services)
        {
            services.AddScoped<IActivityStateRepository, ActivityStateRepository>();
            services.AddScoped<IBuilderBrandRepository, BuilderBrandRepository>();
            services.AddScoped<ICommunityRepository, CommunityRepository>();
            services.AddScoped<ICommunityConfigurationRepository, CommunityConfigurationRepository>();
            services.AddScoped<ICommunitySiteGeoJsonRepository, CommunitySiteGeoJsonRepository>();
            services.AddScoped<ICommunitySiteRepository, CommunitySiteRepository>();
            services.AddScoped<ICommunityUserRepository, CommunityUserRepository>();
            services.AddScoped<IConfigurationRepository, ConfigurationRepository>();
            services.AddScoped<ICustomizedContentRepository, CustomizedContentRepository>();
            services.AddScoped<ICustomizedContentTypeRepository, CustomizedContentTypeRepository>();
            services.AddScoped<ICustomizedLocationRepository, CustomizedLocationRepository>();
            services.AddScoped<IListingRepository, ListingRepository>();
            services.AddScoped<ILotListingRepository, LotListingRepository>();
            services.AddScoped<ILotRepository, LotRepository>();
            services.AddScoped<ILotStateRepository, LotStateRepository>();
            services.AddScoped<IMasterPlanRepository, MasterPlanRepository>();
            services.AddScoped<IProspectConfigurationRepository, ProspectConfigurationRepository>();
            services.AddScoped<IProspectCommunityRepository, ProspectCommunityRepository>();
            services.AddScoped<IPartnerRepository, PartnerRepository>();
            services.AddScoped<IPointOfInterestRepository, PointOfInterestRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<ISiteRepository, SiteRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
        }
    }
}
