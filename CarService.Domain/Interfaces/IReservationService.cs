using CarService.Data.Entity;
using System;

namespace CarService.Domain.Interfaces
{
    public interface IReservationService
    {
        bool TimeIsReserved(DateTime time);
        Reservation Reserve(DateTime reservedDateTime);
    }
}
