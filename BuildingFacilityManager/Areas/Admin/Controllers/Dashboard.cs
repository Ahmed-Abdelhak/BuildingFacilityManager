using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BuildingFacilityManager.Core;
using BuildingFacilityManager.Core.Domain;
using BuildingFacilityManager.Persistence;

namespace BuildingFacilityManager.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        //public DashboardController(IUnitOfWork unitOfWork)
        //{
        //    _unitOfWork = unitOfWork;
        //}

        public DashboardController()
        {
            _unitOfWork = new UnitOfWork(ApplicationDbContext.Create());
        }

        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            var buildings = _unitOfWork.Building.GetAll();
            return View(buildings);
        }

        public ActionResult BuildingBoard()
        {
            return View();
        }
        
    }
}
