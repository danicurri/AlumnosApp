﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Persons
    {
        // Remember! Person extends Object.
        class Person
        {
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";
            public int Age { get; set; }
            public Person(string fName, string lName, int personAge)
            {
                FirstName = fName;
                LastName = lName;
                Age = personAge;
            }
            public override string ToString() => $"[First Name: {FirstName}; Last Name: {LastName}; Age: {Age}]";

            public Person() { }
        }
    }
}
