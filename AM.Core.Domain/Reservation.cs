using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Reservation
    {
        
        public int FlightId { get; set; }
        //Clés étrangères
        public String PassengerId { get; set; }
        public virtual Passenger MyPassenger { get; set; }
        public virtual Flight MyFlight { get; set; }

        public double Price { get; set; }
        public String Seat { get; set; }
        public bool VIP { get; set; }
    }
}
