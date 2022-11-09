using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AM.ApplicationCore.Domaine
{
    public class Flight
    {
        
       public int PlaneId { get; set; }
       public string Airline { get; set; }
        public String Destination { get; set; }
        public string Deparature { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        [ForeignKey("PlaneId")]
        public virtual Plane Plane { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual  ICollection<Passenger> Passengers { get; set; }
        public override string ToString()
        {
            return "Destination = "+ Destination+ " Deparature= "+ Deparature+ " FlightDate = "+ FlightDate+ " FlightId= "+ FlightId+ " DateArrival = "+ EffectiveArrival + " EstimateDuration= "+ EstimatedDuration + " Plane ="+ Plane.ToString()+ " Passenger= ";
        }
       

    }
}
