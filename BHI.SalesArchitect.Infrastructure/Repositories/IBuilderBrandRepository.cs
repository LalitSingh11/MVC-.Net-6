﻿using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface IBuilderBrandRepository
    {
        IEnumerable<BuilderBrand> GetByPartnerId(int partnerId);
    }
}
