using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Data.Repositories
{
    public interface IMaintenanceRepository
    {
        void Create(Entity.Maintenance maintenance);
        void Update(Entity.Maintenance maintenance);
        Entity.Maintenance Get(int id);
        List<Entity.Maintenance> GetMaintenances();
    }
}
