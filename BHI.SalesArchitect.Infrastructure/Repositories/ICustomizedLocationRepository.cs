﻿using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ICustomizedLocationRepository
    {
        Task<IEnumerable<CustomizedLocation>> GetAll();
    }
}
