using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Handling Multiple Exceptions *****\n");
            Car myCar = new Car("Rusty", 90);
            myCar.CrantTunes(true);

            try
            {
                // Trigger an argument out of range exception.
                myCar.Accelerate(-10);
            }
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            // This will catch any other exception
            // beyond CarIsDeadException or
            // ArgumentOutOfRangeException.
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //this always occurs.exception or not.
                myCar.CrantTunes(false);
            }
            Console.ReadLine();
        }
    }
}
