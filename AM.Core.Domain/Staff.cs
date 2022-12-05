using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    //Configuration de l'approche TPH
    //[Table("Staffs")]
    public class Staff : Passenger
    {
        public DateTime EmploymentDate { get; set; }
        public string Function { get; set; }

        [DataType(DataType.Currency,ErrorMessage ="Currency")]
        public double Salary { get; set; }

        public override string ToString()
        {
            return base.ToString()+ 
                "EmploymentDate:" + EmploymentDate +
                ", Function: " + Function +
                ", Salary: " + Salary ;
        }

        public override string GetPassengerType()
        {
            return base.GetPassengerType()+ "I am a staff member";

        }
    }
}
