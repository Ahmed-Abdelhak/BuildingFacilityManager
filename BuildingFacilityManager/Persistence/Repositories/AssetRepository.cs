using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuildingFacilityManager.Core.Domain;
using BuildingFacilityManager.Core.Repositories;

namespace BuildingFacilityManager.Persistence.Repositories
{
    public class AssetRepository:Repository<Asset>,IAssetRepository
    {
        public AssetRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}