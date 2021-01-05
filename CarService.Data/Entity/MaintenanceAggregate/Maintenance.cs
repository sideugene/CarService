using System;
using System.Collections;
using System.Collections.Generic;

namespace CarService.Data.Entity
{
    public class Maintenance
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public DateTime DateTime { get; set; }
        public int CustomerId { get; set; }
        public double Price { get; set; }
    }
}
