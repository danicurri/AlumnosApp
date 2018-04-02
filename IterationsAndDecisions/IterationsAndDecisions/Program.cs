using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            // A basic for loop.
          
            {
                // Note! "i" is only visible within the scope of the for loop.
              

                {
                    for (int i = 0; i < 4; i++)
                    Console.WriteLine("Number is: {0} ", i);
                    Console.ReadLine();
                }
                // "i" is not visible here.
            }

            // Iterate array items using foreach.
            
            {
                string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
                foreach (string c in carTypes)
                Console.WriteLine(c);
                int[] myInts = { 10, 20, 30, 40 };
                foreach (int i in myInts)
                Console.WriteLine(i);
                Console.ReadLine();
            }
            //while loop
            {
                string userIsDone = "";
                // Test on a lower-class copy of the string.
                while (userIsDone.ToLower() != "yes")
                {
                    Console.WriteLine("In while loop");
                    Console.Write("Are you done? [yes] [no]: ");
                    userIsDone = Console.ReadLine();
                }
            }
        }
    }
}
