using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******FUN WITH CLASS TYPES********\n");

            // Make a Motorcycle with a rider named Tiny?
            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.driverName);
            Console.WriteLine();
            // Prints an empty name value!

            //instantiating the motorcycle
            Motorcycle mc = new Motorcycle();
            mc.PopAWheely();

            //invoking the default constructor
            Car chuck = new Car();
            chuck.PrintState();

            //make a car called Mary going 0 km/h.
            Car mary = new Car("Mary");
            mary.PrintState();

            //make a car called Daisy going 75km/.
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();

            //allocate and configure a Car object.
            Car mycar = new Car();
            mycar.petName = "Henry";
            mycar.currSpeed = 10;

            //speed up the car a few times 
            //and print new state out

            for (int i = 0; i <= 10; i++)
            {
                mycar.SpeedUp(5);
                mycar.PrintState();

            }Encapsulation:constructors:
            Console.ReadLine();
        }

    }
}
