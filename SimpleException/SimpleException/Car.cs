using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Car
    {
        //constant for max speed
        public const int maxSpeed = 100;

        //car properties
        public int CurrSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        //is the car operational?
        private bool carIsDead;

        //a car has -a radio
        private Radio theMusicBox = new Radio();

        //constructors
        public Car() { }
        public Car(string name, int speed)
        {
            CurrSpeed = speed;
            PetName = name;
        }
       
        public void CrantTunes(bool state)
        {
            //delegate request to inner object
            theMusicBox.TurnOn(state);
        }

        // This time, throw an exception if the user speeds up beyond MaxSpeed.
        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine("{0} is out of order", PetName);
            else
            {
                CurrSpeed += delta;
                if (CurrSpeed > maxSpeed)
                {
                    Console.WriteLine("{0} has overheated", PetName);
                    CurrSpeed = 0;
                    carIsDead = true;

                    // We need to call the HelpLink property, thus we need
                    // to create a local variable before throwing the Exception object.
                    Exception ex = new Exception($"{PetName} has overheated!");
                    ex.HelpLink = "www.carsrepairs.com";

                    // Stuff in custom data regarding the error.
                    ex.Data.Add("Timestamp", $"The car exploded at {DateTime.Now}");
                    ex.Data.Add("Cause", "You have a heavy foot");
                    throw ex;

                    // Use the "throw" keyword to raise an exception.
                    throw new Exception($"{PetName} has overheated!");
                }
                else
                    Console.WriteLine("=> Current speed = {0}", CurrSpeed);

            }
        }             
    }
}
