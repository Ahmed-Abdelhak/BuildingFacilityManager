using System.Data.Entity;
using BuildingFacilityManager.Core.Domain;
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

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}