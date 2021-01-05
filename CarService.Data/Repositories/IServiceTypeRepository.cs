using CarService.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance.Data.Repositories
{
  public  interface IServiceTypeRepository
    {
        IEnumerable<ServiceType> GetServiceTypes();
    }
}
