using System;
using System.Collections;
namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******simple exception example**********");
            Console.WriteLine("creating a car and stepping into it");
            Car mycar = new Car("zippy", 20);
            mycar.CrantTunes(true);

            // Speed up past the car's max speed to
            // trigger the exception.

            try
            {
                for (int i = 0; i < 10; i++) ;
                mycar.Accelerate(10);
            }
            catch(Exception e)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine("Method: {0}", e.TargetSite);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("\n-> Custom Data:");
                foreach (DictionaryEntry de in e.Data)
                    Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
            }
            // The error has been handled, processing continues with the next statement.
            Console.WriteLine("\n***** Out of exception logic *****");
            Console.ReadLine();
        }
    }
}
