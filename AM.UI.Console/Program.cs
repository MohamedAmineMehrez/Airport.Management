using AM.ApplicationCore;
using AM.ApplicationCore.Domaine;
using AM.ApplicationCore.Services;
using AM.Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {   AMContext context = new AMContext();
        // GenericRepository<Plane> gn = new GenericRepository<Plane>(context);
        UnitOfWork uw = new UnitOfWork(context, typeof(GenericRepository<>));

        ServicePlane service = new ServicePlane(uw);
        service.Add(TestData.Airbusplane);
        //gn.SubmitChanges();
        uw.Save();






       
      //  Plane p = new Plane();
      //  ICollection<Flight> f = new List<Flight>();
      //  p.Capacity = 100;
      //  p.ManufactureDate= DateTime.Now;
      //  p.PlaneId = " KC-767";
      //  p.PlaneType = PlaneType.Boing;
      //  p.Flights= f;
      //  Console.WriteLine(p);
      ////  Plane p1= new Plane(PlaneType.Airbus,200,DateTime.Now);
      //// Console.WriteLine(p1);
        
      //  Plane p2 = new Plane() { Capacity = 400, ManufactureDate = DateTime.Now, PlaneId = "1234", PlaneType=PlaneType.Airbus, Flights = f };
      //  Console.WriteLine(p2);
     
       // Passenger p1=new Passenger {FirstName="nabil",LastName="kallel"};
        ////Console.WriteLine(p1.CheckProfile("nabil", "kallel"));
        ////Console.WriteLine(p1.CheckProfile("nabil","kallel","azerty"));
        //Traveller tr1=new Traveller { FirstName="trv1",LastName="aaaa"};
        //Staff staff=new Staff { FirstName="stf1",LastName="bbbbb"};
        //p1.PassangerType();
        //tr1.PassangerType();
        //staff.PassangerType();

        //ServiceFlight sf=new ServiceFlight();
        //sf.Flights=TestData.listFlights;
        //foreach(var item in sf.GetFlightDates("Paris"))
        //{ Console.WriteLine(item); }
        //sf.GetFlights("Destination", "Paris");
        //sf.DestinationGroupedFlights();
        //Console.WriteLine('************************** Testing Extension methode************');
        //p1.UpperFullName();
        //p1.ToString();
        
    }
}