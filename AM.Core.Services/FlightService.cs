using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;
using AM.Core.Interfaces;

namespace AM.Core.Services
{
    public class FlightService : Service<Flight>, IFlightService
    {
        //IRepository<Flight> repo;

        //readonly IUnitOfWork unitOfWork;

        public IList<Flight> Flights { get; set; }
        public FlightService(IUnitOfWork unitOfWork): base(unitOfWork) 
        {
            //this.unitOfWork = unitOfWork;
            //repo = this.unitOfWork.GetRepository<Flight>();
        }
        public IList<DateTime> GetFlightDates(string destination)
        {
            return Flights.Where(f => f.Destination == destination)
                .Select(f => f.FlightDate)
                .ToList();
            //linq integré
            /*return (from f in Flights
                   where f.Destination == destination
                   select f.FlightDate).ToList();
            */
        }

        public void GetFlights(string filterType, string filterValue)
        { //Destination,Departure,FlightDate,FlightId,EffectiveArrival,EstimatedDuration
            switch (filterType)
            {
                case "Destination":
                    {
                        var result = Flights.Where(f => f.Destination == filterValue).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "Departure":
                    {
                        var result = Flights.Where(f => f.Departure == filterValue).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "FlightDate":
                    {
                        var result = Flights.Where(f => f.FlightDate == DateTime.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "FlightId":
                    {
                        var result = Flights.Where(f => f.FlightId == int.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "EffectiveArrival":
                    {
                        var result = Flights.Where(f => f.EffectiveArrival == DateTime.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "EstimatedDuration":
                    {
                        var result = Flights.Where(f => f.EstimatedDuration == int.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;

            }
        }

      
        public void ShowFlightDetails(Plane plane)
        {
            var result = from f in plane.Flights
                         select new
                         {
                             Destination = f.Destination,
                             FlightDate = f.FlightDate
                         };
            foreach (var obj in result)
            {
                Console.WriteLine(obj.FlightDate + ":" + obj.Destination);
            }
        }
        public int GetWeeklyFlightNumber(DateTime date)
        {
            return Flights.Where(f=>f.FlightDate >= date 
            && f.FlightDate <= date.AddDays(7)).Count();
        }

        public double GetDurationAverage(string destination)
        {
            return Flights.Where(f=>f.Destination == destination)
                .Select(f=>f.EstimatedDuration).Average();


        }

        public IList<Flight> SortFlights()
        {
            return Flights.OrderByDescending(f=>f.EstimatedDuration).ToList();

        }

        public IList<Passenger> GetThreeOlderTravellers(Flight flight)
        {
            //return flight.Passengers
            //    .OfType<Traveller>().OrderByDescending(p=>p.Age)
            //    .Take(3).ToList<Passenger>();
            return new List<Passenger>();
        }

        public void ShowGroupedFlights()
        {
            var result = from f in Flights
                         group f by f.Destination;
            foreach (var group in result)
            {
                Console.WriteLine(group.Key);
                foreach (var f in group)
                {
                    Console.WriteLine(f);
                }
            }

        }

        public Passenger GetSeniorPassenger(IFlightService.GetScore methode)
        {
            //return (from f in Flights
            //       from p in f.Passengers
            //       orderby methode(p) descending
            //       select p).First();
            return new Passenger();
        }

        //public void Add(Flight flight)
        //{
        //     repo.Add(flight);
        //    //repo.Save();
        //    unitOfWork.Save();
        //}

        //public void Delete(Flight flight)
        //{
        //    repo.Delete(flight);
        //    //repo.Save();
        //    unitOfWork.Save();
        //}

        //public IList<Flight> GetAll()
        //{
        //    return repo.GetAll();
         
        //}
    }
}
