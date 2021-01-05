using CarService.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarService.Models
{
    public class MaintanceDetailsViewModel
    {
        public Car Car{ get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public double Price { get; set; }
        public DateTime DateTime { get; set; }
    }
}