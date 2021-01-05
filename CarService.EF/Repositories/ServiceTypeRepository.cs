using Maintenance.Data.Repositories;
using CarService.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.Repositories
{
    public class ServiceTypeRepository : IServiceTypeRepository
    {
        private ServiceContext context;

        public ServiceTypeRepository(ServiceContext context)
        {
            this.context = context;
        }
        public IEnumerable<ServiceType> GetServiceTypes()
        {
                return context.ServiceTypes;
            
        }
    }
}
