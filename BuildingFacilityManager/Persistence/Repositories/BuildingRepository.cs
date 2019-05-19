using BuildingFacilityManager.Core.Domain.Building;
using BuildingFacilityManager.Core.Repositories;

namespace BuildingFacilityManager.Persistence.Repositories
{
    public class BuildingRepository : Repository<Building>, IBuildingRepository
    {
        public BuildingRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}