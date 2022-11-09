using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace AM.ApplicationCore.Domaine
{ public enum PlaneType
    { Boing,
    Airbus}
    public class Plane
    {
        [Range(0,int.MaxValue,ErrorMessage ="ib3id 3al negative SAAAHBI")]
        public double Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
        public override string ToString()
        {
            return "capacity = "+Capacity+ " ManufactureDate = "+ ManufactureDate+ " PlaneId = "+ PlaneId+ " PlaneType = "+ PlaneType;
        }
      /*  public Plane(PlaneType pt, int capacity, DateTime date)
        {
            this.Capacity = Capacity;
            this.ManufactureDate = date;
            this.PlaneType = pt;
        }
        public Plane() 
        { }
      */

    }
}
