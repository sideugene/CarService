using System;

namespace CarService.Data.Entity
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public DateTime ReservedDateTime { get; set; }

        public int? MaintenanceId { get; set; }
    }
}
