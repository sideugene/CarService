using CarService.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF
{
   public class ServiceContext : DbContext
    {
        public DbSet<Data.Entity.Maintenance> Maintenances { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Data.Entity.Maintenance>();
            modelBuilder.Entity<Customer>();
            modelBuilder.Entity<Car>();
            modelBuilder.Entity<Reservation>();
            modelBuilder.Entity<ServiceType>();
        }
    }
}
