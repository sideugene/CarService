using CarService.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarService.Models
{
    public class CountPriceViewModel
    {
       public int MaintenanceId { get; set; }
        public List<ServiceType> Services { get; set; }
    }
}