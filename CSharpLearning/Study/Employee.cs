using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    public class Employee
    {
        public static int count;
        private string employeeID;
        private string firstName, lastName;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }


        static Employee()
        {
            // intialize the static variables in class Employee;
            count =0;
        }

        public Employee(string employeeID) : this(employeeID, "firstName", "lastName")
        {
        }

        public Employee(string employeeID, string firstName, string lastName)
        {
            count++;
            this.employeeID = employeeID;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
