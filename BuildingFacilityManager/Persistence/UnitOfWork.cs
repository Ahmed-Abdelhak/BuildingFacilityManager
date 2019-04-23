using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuildingFacilityManager.Core;
using BuildingFacilityManager.Core.Domain;
using BuildingFacilityManager.Core.Repositories;
using BuildingFacilityManager.Persistence.Repositories;

namespace BuildingFacilityManager.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IAssetRepository Asset { get; private set; }


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Asset = new AssetRepository(_context); 
            
        }



        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();

        }

    }
}