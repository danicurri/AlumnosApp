using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{   
    // Managers need to know their number of stock options.
    class Manager : Employee
    {
        public int StockOptions { get; set; }
    }
        // Add back the default ctor
        // in the Manager class as well.
        public Manager() { }
        public Manager(string fullName, int age, int empID, 
            float currPay, string ssn, int numbOfOptions)
            : base(fullName, age, empID, currPay, ssn)
    {
        // This property is defined by the Manager class.
        StockOptions = numbOfOptions;

        // Assign incoming parameters using the
        // inherited properties of the parent class.
        ID = empID;
        Age = age;
        Name = fullName;
        Pay = currPay;
        // OOPS! This would be a compiler error,
        // if the SSN property were read-only!
        SocialSecurityNumber = ssn;
    }
}
