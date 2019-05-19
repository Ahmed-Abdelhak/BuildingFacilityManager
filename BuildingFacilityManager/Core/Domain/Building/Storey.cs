using System.ComponentModel.DataAnnotations.Schema;

namespace BuildingFacilityManager.Core.Domain.Building
{
    public class Storey
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Building BuildingName { get; set; }
        [ForeignKey("BuildingName")]
        public int BuildingId { get; set; }

    }
}