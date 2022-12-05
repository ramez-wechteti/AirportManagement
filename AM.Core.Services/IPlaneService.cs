using AM.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public interface IPlaneService : IService<Plane>
    {
        //void Add(Plane plane);
        //void Delete(Plane plane);
        //IList<Plane> GetAll();
        IList<Passenger> GetPassengers(Plane plane);
        IList<Flight> GetFlights(int n);
        Boolean IsAvailable(Flight flight, int n);

        void DeleteUselessPlanes();
    }
}
