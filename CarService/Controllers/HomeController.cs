using Maintenance.Data.Repositories;
using CarService.Data.Entity;
using CarService.Data.Repositories;
using CarService.Domain.Interfaces;
using CarService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarService.Controllers
{
    public class HomeController : Controller
    {
        private IReservationService reservationService;
        private IMaintenanceService maintenanceService;
        private IReservationRepository reservationRepository;
        private IMaintenanceRepository maintenanceRepository;
        private ICarRepository carRepository;
        private ICustomerRepository customerRepository;
        private IServiceTypeRepository serviceTypeRepository;
        public HomeController(
            IReservationService reservationService,
            IMaintenanceService maintenanceService, 
            IReservationRepository reservationRepository,
            IMaintenanceRepository maintenanceRepository,
            ICarRepository carRepository,
            ICustomerRepository customerRepository,
            IServiceTypeRepository serviceTypeRepository)
        {
            this.reservationService = reservationService;
            this.maintenanceService = maintenanceService;
            this.reservationRepository = reservationRepository;
            this.maintenanceRepository = maintenanceRepository;
            this.carRepository = carRepository;
            this.customerRepository = customerRepository;
            this.serviceTypeRepository = serviceTypeRepository;
        }

        public ActionResult Index()
        {
            var model = new HomeViewModel {CurrentWeek = new List<DateTime>() };
            for(var cd = DateTime.Now; cd < DateTime.Now.AddDays(30); cd = cd.AddDays(1))
            {
                model.CurrentWeek.Add(cd);
            }
            return View(model);
        }

        public ActionResult TimesForDay(DateTime date)
        {
            var model = new TimesForDayViewModel { IsReservedTimes = new Dictionary<DateTime, bool>() };
            for(var dt = date.Date.AddHours(9); dt.Hour <= 18; dt = dt.AddHours(1))
            {
                model.IsReservedTimes.Add(dt, reservationService.TimeIsReserved(dt));
            }
            return View(model);
        }

        public ActionResult Reservation(DateTime? dateTime)
        {
            var reservation = reservationService.Reserve(dateTime.Value);
            var model = new ReservationViewModel { Reservation = reservation };
            return View(model);
        }

        [HttpPost]
        public ActionResult Reservation(Car car, Customer customer, int reservationId )
        {
                carRepository.Create(car);
                customerRepository.Create(customer);
                var reservation = reservationRepository.Get(reservationId);
                var maintenance = maintenanceService.Create(car.Id, customer.Id, reservation);
                var services = serviceTypeRepository.GetServiceTypes().ToList();
                return View("CountPrice", new CountPriceViewModel { MaintenanceId = maintenance.Id, Services = services });
        }

        public ActionResult MaintenanceDetails(int maintenanceId, double markUp)
        {
            var maintenance = maintenanceRepository.Get(maintenanceId);
            maintenance.Price += markUp;
            maintenanceRepository.Update(maintenance);
            var car = carRepository.Get(maintenance.CarId);
            var customer = customerRepository.Get(maintenance.CustomerId);
            var model = new MaintanceDetailsViewModel
            {
                Car = car,
                CustomerName = customer.Name,
                CustomerSurname = customer.Surname,
                DateTime = maintenance.DateTime,
                Price = maintenance.Price
            };
            return View(model);
        }
    }
}