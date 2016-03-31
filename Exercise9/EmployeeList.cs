using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class EmployeeList
    {
        public List<Employee> Employees { get; private set; }

        public EmployeeList()
        {
            Employees = new List<Employee>();
        }
        public void Store(Employee newEmployee)
        {
            Employees.Add(newEmployee);
        }
        public void RemoveEmployeeBySsn(string ssn)
        {
            Employee EmployeeToRemove = null;

            foreach (var employee in Employees)
            {
                if(employee.Ssn == ssn)
                {
                    EmployeeToRemove = employee;
                    break;
                }
            }

            if (EmployeeToRemove != null)
            {
                Employees.Remove(EmployeeToRemove);
            }
        }


    }
}
