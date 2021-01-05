using Maintenance.Data.Repositories;
using CarService.Data.Repositories;
using CarService.Domain.Interfaces;
using CarService.Domain.Services;
using CarService.EF.Repositories;
using Ninject.Modules;

namespace CarService
{
    internal class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IReservationRepository>().To<ReservationRepository>();
            Bind<IMaintenanceRepository>().To<MaintenanceRepository>();
            Bind<ICustomerRepository>().To<CustomerRepository>();
            Bind<ICarRepository>().To<CarRepository>();
            Bind<IServiceTypeRepository>().To<ServiceTypeRepository>();

            Bind<IMaintenanceService>().To<CarService.Domain.Services.MaintenanceService>();
            Bind<IReservationService>().To<ReservationService>();
        }
    }
}