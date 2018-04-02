using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("***** Fun with Encapsulation *****\n");
                Employee emp = new Employee("Marvin", 456, 30000);
                Employee joe = new Employee();
                joe.Age++;
                emp.GiveBonus(1000);
                emp.DisplayStats();
                // Reset and then get the Name property.
                emp.Name = "Marv";
                joe.Name = "Joe";
                Console.WriteLine("Employees are named: {0} and {1}", emp.Name, joe.Name);
                Console.ReadLine();
            }
        }
    }
}
