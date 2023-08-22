﻿using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface IListingRepository
    {
        IEnumerable<Listing> GetByCommunityId(int communityId);
        IEnumerable<Listing> GetByLotId(int lotId);
    }
}
