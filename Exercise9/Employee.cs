﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Ssn { get; private set; }
        public string Wage { get; private set; }


        public Employee(string firstName, string lastName, string ssn, string wage)
        {

            FirstName = firstName;
            LastName = lastName;
            Ssn = ssn;
            Wage = wage;
        }

    }

}
