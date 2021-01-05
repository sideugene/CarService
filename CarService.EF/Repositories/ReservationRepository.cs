using CarService.Data.Entity;
using CarService.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private ServiceContext context;

        public ReservationRepository(ServiceContext context)
        {
            this.context = context;
        }
        public void Create(Reservation reservation)
        {
                context.Reservations.Add(reservation);
                context.SaveChanges();
            
        }

        public Reservation Get(int id)
        {
                return context.Reservations
                    .FirstOrDefault(r => r.Id == id);
            
        }

        public List<Reservation> GetReservations()
        {
                return context.Reservations.ToList();
            
        }

        public void Remove(Reservation reservation)
        {
                context.Entry(reservation).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            
        }

        public void Update(Reservation reservation)
        {
                context.Entry(reservation).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            
        }
    }
}
