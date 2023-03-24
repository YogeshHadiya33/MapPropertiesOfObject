using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapPropertiesOfObject
{

    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public double Salary { get; set; }
        public DateTime Dob { get; set; }

        public Department Department { get; set; }
    }

    public class NewEmployee
    {
        public int? EmployeeId { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string addressline1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public double Salary { get; set; }
        public DateTime Dob { get; set; }

        public Department Department { get; set; }
    }

}
