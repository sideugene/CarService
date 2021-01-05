using CarService.Data.Entity;

namespace CarService.Domain.Interfaces
{
    public interface IMaintenanceService
    {
        Data.Entity.Maintenance Create(int carId, int customerId, Reservation reservation);
    }
}
