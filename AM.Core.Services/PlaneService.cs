using AM.Core.Domain;
using AM.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public class PlaneService : Service<Plane>,IPlaneService
    {
        //IRepository<Plane> repo;

        //readonly IUnitOfWork unitOfWork;
        public PlaneService(IUnitOfWork unitOfWork):base(unitOfWork)
        {
            //this.unitOfWork = unitOfWork;
            //this.repo = unitOfWork.GetRepository<Plane>();
        }

        public void DeleteUselessPlanes()
        {
            var unusedPlanes = GetAll()
                .Where(p => p.Flights
                                .All(f => f.FlightDate <= DateTime.Now.AddYears(-1))
                      ).ToList();
            //foreach(var plane in unusedPlanes)
            //{
            //    Delete(plane);
            //}

            //Optimisation de performance
            Delete(unusedPlanes);
                
        }

        public IList<Flight> GetFlights(int n)
        {
            return GetAll()
                .OrderByDescending(p => p.ManifactureDate)
                .Take(n)
                .SelectMany(p => p.Flights)
                .OrderBy(f => f.FlightDate)
                .ToList();
        }

        public IList<Passenger> GetPassengers(Plane plane)
        {
            return Get(plane.PlaneId)
                   .Flights
                   .SelectMany(f => f.Reservations)
                   .Select(r => r.MyPassenger)
                   .Distinct()
                   .ToList();
        }

        public bool IsAvailable(Flight flight, int n)
        {
            var flightDB = unitOfWork.GetRepository<Flight>()
                .Get(flight.FlightId);

            return flightDB.Reservations.Count() + n
            <= flightDB.MyPlane.Capacity;

            
                
        }
        //public void Add(Plane plane)
        //{
        //    repo.Add(plane);
        //    //repo.Save();
        //    unitOfWork.Save();
        //}

        //public void Delete(Plane plane)
        //{

        //    repo.Delete(plane);
        //    //repo.Save();
        //    unitOfWork.Save();
        //}

        //public IList<Plane> GetAll()
        //{
        //    return repo.GetAll();
        //}
    }
}
