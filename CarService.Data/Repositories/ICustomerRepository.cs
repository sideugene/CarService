using CarService.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Data.Repositories
{
    public interface ICustomerRepository
    {
        void Create(Customer customer);
        Customer Get(int id);
        List<Customer> GetCustomers();
    }
}
