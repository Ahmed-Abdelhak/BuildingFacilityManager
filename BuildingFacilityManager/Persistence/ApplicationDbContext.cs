using System.Data.Entity;
using BuildingFacilityManager.Core.Domain;
using BuildingFacilityManager.Core.Domain.Building;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BuildingFacilityManager.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Storey> Stories { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}