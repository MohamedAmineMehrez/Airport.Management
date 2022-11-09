using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AM.ApplicationCore.Domaine
{
    public class Passenger
    {
        [Display(Name ="Date of Birth")]
        [DataType(DataType.Date)]  
        public DateTime BirthDate { get; set; }
        [Key]
        public int Id { get; set; }
        [StringLength(7,ErrorMessage ="no")]
        public string PassportNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        
        public FullName Fullname { get; set; }
        [RegularExpression(@"^[0-9]{8}$",ErrorMessage ="invalid phone number!!!!")]
        public int TelNumber { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public override string ToString()
        {
            return "BirthDate = " + BirthDate + " PasseportNumber = " + PassportNumber + " EmailAdress = " + EmailAddress + " FirstName = " + Fullname.FirstName + " LastName = " + Fullname.LastName + " TelNumber = " + TelNumber + " Flights = " + Flights.ToString();
        }
        public bool CheckProfile(string firstName, string lastName)
        { return (this.Fullname.FirstName == firstName) && (this.Fullname.LastName == lastName); }
        public bool CheckProfile(string firstName, string lastName, string mail)
        {
            return (this.Fullname.FirstName == firstName) && (this.Fullname.LastName == lastName) && (this.EmailAddress == mail);
        }
        public virtual void PassangerType()
        {
            Console.WriteLine("I'm a passanger");
        }
    }
}
