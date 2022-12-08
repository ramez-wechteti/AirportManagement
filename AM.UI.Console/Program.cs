// See https://aka.ms/new-console-template for more information

using AM.Core.Extensions;
using AM.Core.Domain;
using AM.Data;
using System.ComponentModel.DataAnnotations;
using  AM.Core.Services;
using AM.Core.Interfaces;

//Plane p1 = new Plane();
//p1.Capacity = 200;
//p1.ManifactureDate = new DateTime(2000,1,1);
//p1.MyPlaneType = PlaneType.Boing;

//Plane p2 = new Plane(PlaneType.AirBus, 500, new DateTime(2000, 1, 1));

//Plane p3 = new Plane() { 
//    Capacity = 200,
//    ManifactureDate=new DateTime(2000, 1, 1),
//    MyPlaneType = PlaneType.AirBus
//};

//Testing question 12
//passenger
//DateTime bday = new DateTime(2000, 5, 25);
//String passportN = "ABC06283";
//String EmailAdd = "cyrine.tr@gmail.com";
//String firstName = "Cyrine";
//String lastName = "Trabelsi";
//String telNumber = "25147623";
//Passenger pas1 = new Passenger(bday, passportN, EmailAdd, firstName, lastName, telNumber, new List<Flight>());


//Console.WriteLine(pas1.GetPassengerType());

////traveller
//Passenger pas2 = new Traveller();
//pas2.BirthDate = new DateTime(2000, 5, 25);
//pas2.EmailAddress = "cyrine.tr@gmail.com";
//pas2.FirstName = "Cyrine";
//pas2.LastName = "Trabelsi";
//pas2.Flights = new List<Flight>();
//pas2.PassportNumber = "ABC06283";
//pas2.TelNumber = "25147623";

//Console.WriteLine(pas2.GetPassengerType());

//staff
//Passenger pas3 = new Staff();
//pas3.BirthDate = new DateTime(2000, 1, 1);
//pas3.EmailAddress = "cyrine.tr@gmail.com";
//pas3.FirstName = "Cyrine";
//pas3.LastName = "Trabelsi";
//pas3.Flights = new List<Flight>();
//pas3.PassportNumber = "ABC06283";
//pas3.TelNumber = "25147623";

////Console.WriteLine(pas3.GetPassengerType());

////Testing question 13
//Passenger pass = new Passenger();
//int age = 0;
//pass.GetAge(new DateTime(2000, 1, 1), ref age);
////pass.GetAge(pas3);

//Console.WriteLine("1st meth:" + age + " ans");
//Console.WriteLine("2nd meth:" + pas3.Age + " ans");

//////Testing question 14
////Console.WriteLine("L'âge est: " + pas3.Age + " ans");

//IFlightService.GetScore meth1 = delegate(Passenger p)
//{ return p.Flights.Count(); };
//IFlightService.GetScore meth2 = delegate (Passenger p)
//{
//    return p.Flights.Where(f => f.Destination == "Tunis" || f.Departure == "Tunis")
//       .Count();

//};
//IFlightService flightService = new FlightService();
//Passenger passengerSenior = flightService.GetSeniorPassenger(meth1);
//Plane plane = new Plane()
//{
//   Capacity = 20,
//   ManifactureDate = new DateTime(2000, 10, 18, 7, 0, 0),
//   MyPlaneType = PlaneType.Boing
//};

//Flight flight = new Flight()
//{
//    FlightDate = new DateTime(2022,10,18,7,0,0),
//    EstimatedDuration=120,
//    EffectiveArrival= new DateTime(2022, 10, 18, 9, 20, 0),
//    Comment = "Comment"
//};
//Console.WriteLine(flight.GetDelay());

//AMContext context = new AMContext();
//context.Planes.Add(plane);
////context.Flights.Add(flight);
//context.SaveChanges();

//Passenger passenger = new Passenger()
//{ BirthDate = new DateTime(2000, 1, 1),
//    PassportNumber = "1234569",
//    EmailAddress = "passenger@gmail.com",
//    MyFullName = new FullName()
//    {
//        FirstName = "Passenger",
//        LastName = "Passenger LN"
//    },
//    TelNumber="96069516"
//};

//Staff staff = new Staff()
//{
//    BirthDate = new DateTime(2000, 1, 1),
//    PassportNumber = "1234561",
//    EmailAddress = "staff@gmail.com",
//    MyFullName = new FullName()
//    {
//        FirstName = "Staff",
//        LastName = "Staff LN"
//    },
//    TelNumber = "96069516",
//    Salary=5000,
//    Function="Pilot",
//    EmploymentDate=new DateTime(1999,1,1)
//};

//Traveller traveller = new Traveller()
//{
//    BirthDate = new DateTime(2000, 1, 1),
//    PassportNumber = "1234560",
//    EmailAddress = "traveller@gmail.com",
//    MyFullName = new FullName()
//    {
//        FirstName = "Traveller",
//        LastName = "Traveller LN"
//    },
//    TelNumber = "96069516",
//    HealthInformation = "",
//    Nationality = "TN"
//};

//AMContext context2 = new AMContext();
//context2.Passengers.Add(passenger);
//context2.Passengers.Add(staff);
//context2.Passengers.Add(traveller);
//context2.SaveChanges();

//#region 14/11/2022
//Passenger passenger2 = new Passenger()
//{
//    BirthDate = new DateTime(2000, 1, 1),
//    PassportNumber = "1111111",
//    EmailAddress = "passenger@gmail.com",
//    MyFullName = new FullName()
//    {
//        FirstName = "Passenger",
//        LastName = "Passenger LN"
//    },
//    TelNumber = "96069516"
//};

//Flight flight2 = new Flight()
//{
//    Destination = "Paris",
//    Departure ="Tunis",
//    FlightDate = new DateTime(2022, 10, 18, 7, 0, 0),
//    EstimatedDuration = 120,
//    EffectiveArrival = new DateTime(2022, 10, 18, 9, 20, 0),
//    Comment = "Comment"
//};

//Reservation reservation = new Reservation()
//{
//    MyPassenger = passenger2,
//    MyFlight = flight2,
//    Price = 500,
//    Seat="Near window",
//    VIP=true
//};

//AMContext context3 = new AMContext();
////context3.Passengers.Add(passenger2);
////context3.Flights.Add(flight2); //1ere meth
////context3.Add(reservation); //2eme meth
////context3.SaveChanges();

////Question 10

//Plane p3 = new Plane()
//{
//    Capacity = 100,
//    ManifactureDate = new DateTime(2000, 1, 1),
//    MyPlaneType = PlaneType.AirBus
//};

//Flight flight3 = new Flight()
//{
//    Destination = "Canada",
//    Departure = "Tunis",
//    FlightDate = new DateTime(2022, 10, 18, 7, 0, 0),
//    EstimatedDuration = 120,
//    EffectiveArrival = new DateTime(2022, 10, 18, 9, 20, 0),
//    Comment = "Comment",
//    MyPlane = p3
//};

////context3.Add(flight3); //2eme meth
////context3.Add(p3); //2eme meth
////context3.SaveChanges();

////Console.WriteLine(flight3.MyPlane);

////Question 11
//Flight flight4 = (Flight)context3.Find(typeof(Flight),3);
//Console.WriteLine(flight4.MyPlane);
//#endregion

#region 28/11/2022
//AMContext context = new AMContext();
//IRepository<Flight> flightRepo = new Repository<Flight>(context);
//IFlightService flightService = new FlightService(flightRepo);
//flightService.Add(new Flight()
//{
//    Destination = "Qatar",
//    Departure = "Tunis",
//    FlightDate = new DateTime(2022, 10, 18, 7, 0, 0),
//    EstimatedDuration = 120,
//    EffectiveArrival = new DateTime(2022, 10, 18, 9, 20, 0),
//    Comment = "Comment"
//});

//IRepository<Plane> planeRepo = new Repository<Plane>(context);
//IPlaneService planeService = new PlaneService(planeRepo);
//planeService.Add(new Plane()
//{
//    Capacity = 100,
//    ManifactureDate = new DateTime(2000, 1, 1),
//    MyPlaneType = PlaneType.AirBus
//});

#endregion


#region 05/12/2022
//Q12
//AMContext context = new AMContext();
//IUnitOfWork unitOfWork = new UnitOfWork(context);
//IFlightService flightService = new FlightService(unitOfWork);
//flightService.Add(new Flight()
//{
//    Destination = "Qatar",
//    Departure = "Tunis",
//    FlightDate = new DateTime(2022, 10, 18, 7, 0, 0),
//    EstimatedDuration = 120,
//    EffectiveArrival = new DateTime(2022, 10, 18, 9, 20, 0),
//    Comment = "Comment"
//});


//IPlaneService planeService = new PlaneService(unitOfWork);
//planeService.Add(new Plane()
//{
//    Capacity = 100,
//    ManifactureDate = new DateTime(2000, 1, 1),
//    MyPlaneType = PlaneType.AirBus
//});
#endregion

#region 08/12/2022

AMContext context = new AMContext();
IUnitOfWork unitOfWork = new UnitOfWork(context);
IFlightService flightService = new FlightService(unitOfWork);
flightService.Add(new Flight()
{
    Destination = "Qatar",
    Departure = "Tunis",
    FlightDate = new DateTime(2022, 10, 18, 7, 0, 0),
    EstimatedDuration = 20,
    EffectiveArrival = new DateTime(2022, 10, 18, 9, 20, 0),
    Comment = "Comment"
});

flightService.Add(new Flight()
{
    Destination = "Paris",
    Departure = "Madrid",
    FlightDate = new DateTime(2022, 10, 19, 7, 0, 0),
    EstimatedDuration = 200,
    EffectiveArrival = new DateTime(2022, 10, 22, 9, 20, 0),
    Comment = "Comment"
});

flightService.Add(new Flight()
{
    Destination = "London",
    Departure = "Tunis",
    FlightDate = new DateTime(2022, 10, 23, 7, 0, 0),
    EstimatedDuration = 120,
    EffectiveArrival = new DateTime(2022, 10, 24, 9, 20, 0),
    Comment = "Comment"
});
#endregion