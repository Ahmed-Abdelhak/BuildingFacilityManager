using BuildingFacilityManager.Core.Domain.Building;
using BuildingFacilityManager.Core.Repositories;

namespace BuildingFacilityManager.Persistence.Repositories
{
    public class StoreyRepository : Repository<Storey>, IStoreyRepository
    {
        public StoreyRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}