using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BuildingFacilityManager.Core.Domain.Building
{
    public class Building
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Storey> Stories { get; set; }
    }
}