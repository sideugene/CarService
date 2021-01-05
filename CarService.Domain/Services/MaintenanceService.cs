using CarService.Data.Entity;
using CarService.Data.Repositories;
using CarService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Domain.Services
{
    public class MaintenanceService : IMaintenanceService
    {
        private IMaintenanceRepository maintenanceRepository;
        private ICustomerRepository customerRepository;
        private IReservationRepository reservationRepository;

        public MaintenanceService( 
            IMaintenanceRepository maintenanceRepository, 
            ICustomerRepository customerRepository,
            IReservationRepository reservationRepository)
        {
            this.maintenanceRepository = maintenanceRepository;
            this.customerRepository = customerRepository;
            this.reservationRepository = reservationRepository;
        }


        public Data.Entity.Maintenance Create(int carId, int customerId, Reservation reservation)
        {
            var maintenance = new Data.Entity.Maintenance
            {
                CarId = carId,
                CustomerId = customerId,
                DateTime = reservation.ReservedDateTime,
                Price = 100
            };

            maintenanceRepository.Create(maintenance);
            reservation.MaintenanceId = maintenance.Id;
            reservationRepository.Update(reservation);

            return maintenance;
        }
    }
}
