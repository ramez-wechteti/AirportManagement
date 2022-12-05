using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public enum PlaneType
    {
        Boing = 0, AirBus = 1
    }
    public class Plane
    {
        [Range(0, int.MaxValue,ErrorMessage ="positive integer")]
        public int Capacity { get; set; }
        public DateTime ManifactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType MyPlaneType { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }

        public Plane()
        {

        }

        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            Capacity = capacity;
            ManifactureDate = date;
            MyPlaneType = pt;
        }

        public override string ToString()
        {
            return "Capacity:" + Capacity +
                ", ManifactureDate: " + ManifactureDate +
                ", PlaneId: " + PlaneId+
                ", Plane Type: "+ MyPlaneType;
        }


    }


}
