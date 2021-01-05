using CarService.Data.Entity;
using CarService.Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace CarService.EF.Repositories
{
    public class MaintenanceRepository : IMaintenanceRepository
    {
        private ServiceContext context;

        public MaintenanceRepository(ServiceContext context)
        {
            this.context = context;
        }
        public void Create(Data.Entity.Maintenance maintenance)
        {
                context.Maintenances.Add(maintenance);
                context.SaveChanges();
        }

        public Data.Entity.Maintenance Get(int id)
        {
                return context.Maintenances.FirstOrDefault(m => m.Id == id);
         
        }

        public List<Data.Entity.Maintenance> GetMaintenances()
        {
                return context.Maintenances.ToList();
            
        }

        public void Update(Data.Entity.Maintenance maintenance)
        {
                context.Entry(maintenance).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            
        }
    }
}
