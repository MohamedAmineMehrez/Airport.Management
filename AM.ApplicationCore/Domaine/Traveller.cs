using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AM.ApplicationCore.Domaine
{
    public class Traveller : Passenger
    {
        
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }
        public override string ToString()
        {
            return base.ToString()+ " HelthInformation = "+ HealthInformation + " Nationality = "+ Nationality;
        }
        public override void PassangerType()
        {
            base.PassangerType();
            Console.WriteLine(" and i'm a traveller");
        }
    }
}
