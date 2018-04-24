using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    // Salespeople need to know their number of sales.
    class SalesPerson : Employee

    {
        public int SalesNumber { get; set; }
    }

    // As a general rule, all subclasses should explicitly call an appropriate
    // base class constructor.
    {
        // Add back the default ctor
        // in the Manager class as well.
        public SalesPerson() { }
        public SalesPerson (string fullName, int age, int empID, float currPay, 
                string ssn, int numbOfSales)
            : base(fullName, age, empID, currPay, ssn)
    }

    {
        // This belongs with us
        SalesNumber = numbOfSales;
    {
}
