using AM.ApplicationCore.Domaine;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight: IServiceFlight
    {
        public List<Flight> Flights { get; set; }

        public List<DateTime> GetFlightDates(string destination)
        {
            //List<DateTime> result = new List<DateTime>();
            ////for(int i = 0; i < Flights.Count; i++)
            ////{
            ////    if (Flights[i].Destination == destination)
            ////    {
            ////        result.Add(Flights[i].FlightDate);

            ////    }

            ////}
            //foreach(var item in Flights)
            //{
            //    if(item.Destination == destination)
            //    {
            //        result.Add(item.FlightDate);
            //    }
            //}
            //return result;
            var query =
                from flight in Flights
                where flight.Destination == destination
                select flight.FlightDate;
            
            
            var query1 = Flights.Where(f => f.Destination == destination).Select(f => f.FlightDate);
            
            
            return query.ToList();
            
        }

        public void GetFlights(string FiltreType, string FiltreValue)
        {
            switch(FiltreType)
            {
                case "Destination":
                    foreach(var item in Flights)
                    {
                        if(item.Destination==FiltreValue)
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (var item in Flights)
                    {
                        if (item.FlightDate == DateTime.Parse( FiltreValue))
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                    break;
                case "EffectiveArrival":
                    foreach (var item in Flights)
                    {
                        if (item.EffectiveArrival == DateTime.Parse(FiltreValue))
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                    break;
                    default:
                    Console.WriteLine("choix erooné");
                    break;
            }
        }
        public void ShowFlightDetails(Plane plane)
        {
            var quary = from Flight in Flights
                        where Flight.Plane == plane
                        select new { 
                            Flight.Destination, 
                            Flight.FlightDate 
                        };
            var quary2 = Flights.Where(f => f.Plane == plane).Select(f => new { f.Destination, f.FlightDate });
            foreach(var f in quary)
            {
                Console.Write("destination"+f.Destination +"date"+f.FlightDate);
            }
            
        }
        public int  ProgrammeDFlightNumber(DateTime startDate)
        { 
            return Flights.Where(f => 
            DateTime.Compare(f.FlightDate, startDate) > 0 && (f.FlightDate - startDate).TotalDays <= 7).Count();
        }
        public double DurationAverage(string destination)
        {
            var query = (from Flight in Flights
                         where Flight.Destination == destination
                         select Flight.EstimatedDuration).Average();
            var query2 = Flights.Where(f =>f.Destination == destination).Select(f=>f.EstimatedDuration).Average();
            return query;
        } 
        public List<Flight> OrderDurationFlights()
        {
            return (from Flight in Flights
                   orderby Flight.EstimatedDuration descending
                   select Flight).ToList();
            return Flights.OrderByDescending(f=>f.EstimatedDuration).ToList();
        }
        public List<Traveller>SeniorTravellers(Flight flight)
        {
            var query = 
                from traveller in 
                    flight.Passengers.OfType<Traveller>()
                    orderby traveller.BirthDate 
                select traveller;
            return query.Take(3).ToList();
        } 

            public void DestinationGroupedFlights()
        {/*var quary = from Flight in Flights
                     where */


            var quary = Flights.GroupBy(f => f.Destination);
            foreach (var res in quary)
            {
                Console.WriteLine(res.Key);
                foreach (var f in res)
                {
                    Console.WriteLine(f);
                }
            }
        }
        public Action<Plane> FlightDetailsDel;
        public Func<string, double> DurationAverageDel;
        public ServiceFlight()
        {
            DurationAverageDel = DurationAverage;
            FlightDetailsDel = ShowFlightDetails;
            
        }
    }
    
}
