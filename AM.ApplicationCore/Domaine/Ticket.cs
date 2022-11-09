using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domaine
{
    public class Ticket
    {
        public float Prix { get; set; }
        public int siege { get; set; }
        public Boolean VIP { get; set; }
        public virtual Passenger passenger { get; set; }
        public virtual Flight flight { get; set; }
        public int PassengerFK { get; set; }
        public int FlightFK { get; set; }
        public int NumTicket { get; set; }
    }
}
