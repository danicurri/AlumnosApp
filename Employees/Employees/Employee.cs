using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Employee
    {
        // Field data.
        private string empName;
        private int empID;
        private float currPay;
        // New field and property.
        private int empAge;
        private string empSSN;

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        // Updated constructors.
        public Employee() { }
        public Employee(string name, int age, int id, float pay, string ssn)
        : this(name, age, id, pay)
        {
            empSSN = ssn;
        }
        public Employee(string name, int age, int id, float pay)
        {
            empName = name;
            empID = id;
            empAge = age;
            currPay = pay;
        }
        // Updated DisplayStats() method now accounts for age.
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Age: {0}", empAge);
            Console.WriteLine("Pay: {0}", currPay);

        }
    
    // Methods.
    public void GiveBonus(float amount)
        {
            currPay += amount;
        }

        // Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                // Here, value is really a string.
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                else
                    empName = value;
                
            }
        }
    }
}
