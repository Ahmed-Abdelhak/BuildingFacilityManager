using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuildingFacilityManager.Core.Repositories;

namespace BuildingFacilityManager.Core
{
    public interface IUnitOfWork:IDisposable
    {
        IBuildingRepository Building { get; }
        IStoreyRepository Storey { get; }
        IAssetRepository Asset { get; }
        int Complete();
    }
}