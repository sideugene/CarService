using CarService.Data.Entity;
using CarService.Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace CarService.EF.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private ServiceContext context;

        public CustomerRepository(ServiceContext context)
        {
            this.context = context;
        }
        public void Create(Customer customer)
        {
                context.Customers.Add(customer);
                context.SaveChanges();
        }

        public Customer Get(int id)
        {
                return context.Customers.FirstOrDefault(c => c.Id == id);
        }

        public List<Customer> GetCustomers()
        {
                return context.Customers.ToList();
        }
    }
}
