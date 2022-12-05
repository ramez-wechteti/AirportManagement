using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Passenger
    {

        [DataType(DataType.DateTime,ErrorMessage ="DateTime") ]
        [Display(Name ="date of birth")]
        public DateTime BirthDate { get; set; }

        [Key]
        [MaxLength(7,ErrorMessage ="MaxLenght is 7")]
        [MinLength(7, ErrorMessage = "MinLenght is 7")]

        public string PassportNumber { get; set; }

        [DataType(DataType.EmailAddress,ErrorMessage ="Email Adress")] 
        
        //[EmailAddress]
        public string EmailAddress { get; set; }

        //[MaxLength(25,ErrorMessage ="Max length is 25"),
        // [MinLength (3,ErrorMessage ="Min length is 3")]
        // public string FirstName { get; set; }
        //public string LastName { get; set; }

        public FullName MyFullName { get; set; }

        [DataType(DataType.PhoneNumber,ErrorMessage ="phone Number")]
        //[Phone]
        public string TelNumber { get; set; }
        //public int Id { get; set; }

        //Question 14
        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - BirthDate.Year;

                if (DateTime.Now.Month < BirthDate.Month)
                    age--;

                if ((DateTime.Now.Month == BirthDate.Month) && (DateTime.Now.Day < BirthDate.Day))
                    age--;
                return age;
            }
        }
        //public ICollection<Flight> Flights { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }

        public Passenger()
        {

        }

        public Passenger(DateTime birthDate, string passportNumber, string emailAddress, string firstName, string lastName, string telNumber, ICollection<Flight> flights)
        {
            BirthDate = birthDate;
            PassportNumber = passportNumber;
            EmailAddress = emailAddress;
            MyFullName.FirstName = firstName;
            MyFullName.LastName = lastName;
            TelNumber = telNumber;
            //Flights = flights;
        }



        //public bool CheckProfile (string firstname, string lastname)
        //{
        //    return FirstName == firstname 
        //        && LastName == lastname;
        //}
        //public bool CheckProfile (string firstname, string lastname, string emailaddress)
        //{
        //    return FirstName == firstname 
        //        && LastName == lastname 
        //        && EmailAddress == emailaddress;
        //}
        public bool CheckProfile(string firstname, 
            string lastname, 
            string emailaddress=null)
        {
            //if (emailaddress == null)
            //    return FirstName == firstname
            //    && LastName == lastname;
            //else
            //    return FirstName == firstname
            //    && LastName == lastname
            //    && EmailAddress == emailaddress;

            return MyFullName.FirstName == firstname
                && MyFullName.LastName == lastname
                && (emailaddress == null || EmailAddress == emailaddress);
        }

        //Question 12
        public virtual string GetPassengerType()
        {
                return "I am a passenger";
        }

        //Question 13
        public void GetAge(DateTime birthDate, ref int calculatedAge)
        {
            //calcul de l'âge théorique sans prendre en considération le mois et le jour
            calculatedAge = DateTime.Now.Year - birthDate.Year;
            //calcul de lâge en prenant en considération le mois de naissance 
            if (DateTime.Now.Month < birthDate.Month)
                calculatedAge--;
            //calcul de lâge en prenant en considération le mois ET LE JOUR de naissance 
            if ((DateTime.Now.Month == birthDate.Month) && (DateTime.Now.Day < birthDate.Day))
                calculatedAge--;
        }
        //public void GetAge(Passenger aPassenger)
        //{
        //    aPassenger.Age = DateTime.Now.Year - aPassenger.BirthDate.Year;
        //    if (DateTime.Now.Month < aPassenger.BirthDate.Month)
        //        aPassenger.Age--;
        //    if ((DateTime.Now.Month == aPassenger.BirthDate.Month) && (DateTime.Now.Day < aPassenger.BirthDate.Day))
        //        aPassenger.Age--;
        //}

        public override string ToString()
        {
            return "BirthDate:"+BirthDate+
                ", PassportNumber: "+ PassportNumber+
                ", EmailAddress: "+ EmailAddress+
                ", FirstName: "+ MyFullName.FirstName +
                ", LastName: "+ MyFullName.LastName +
                ", TelNumber: "+ TelNumber;
        }
    }
}
