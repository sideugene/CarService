using CarService.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarService.Models
{
    public class ReservationViewModel
    {
        public Reservation Reservation{ get; set; }
        public Car Car { get; set; }
        public Customer Customer { get; set; }
    }
}