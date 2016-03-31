using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListOfEmployees = new EmployeeList();
            var Notification = new Logger();
            string _name;
            string _surname;
            string _ssn;
            string _wage;
            while (true)
            {

                Console.WriteLine(@"1 - Add employee
2 - Remove employee
3 - Print entire registry
4 - Print all notifications
5 - Exit
Enter choice: ");
                var choice = (Console.ReadLine());
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter First name: ");
                        _name = Console.ReadLine();
                        Console.Write("Surname: ");
                        _surname = Console.ReadLine();
                        Console.Write("Social security number: ");
                        _ssn = Console.ReadLine();
                        Console.Write("hourly wage: ");
                        _wage = Console.ReadLine();
                        Employee Emp1 = new Employee(_name, _surname, _ssn, _wage);
                        ListOfEmployees.Store(Emp1);
                        Notification.Log("New employee has been added!");
                        break;
                    case "2":
                        Console.Write("Enter the SSN of the employee to remove: ");
                        ListOfEmployees.RemoveEmployeeBySsn(Console.ReadLine());
                        Notification.Log("Employee has been removed!");
                        break;
                    case "3":
                        foreach (var employee in ListOfEmployees.Employees)
                        {
                            Console.WriteLine(employee.ToString());
                        }
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    case "4":
                        foreach (var Log in Notification.LogPosts)
                        {
                            Console.WriteLine(Log);
                        }
                        Console.WriteLine("\nThat's all folks!\nPress enter to continue");
                        Console.ReadKey();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("This menu option does not exist");
                        break;
                }
                Console.WriteLine("Great Success!");
                Thread.Sleep(1500);
                Console.Clear();
            }




        }
    }
}
