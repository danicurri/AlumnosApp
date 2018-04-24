using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
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

        // Test for invalid argument before proceeding.
        public void Accelerate(int delta)
        {
            if (delta < 0)
                throw new
                    ArgumentOutOfRangeException("delta", "speed should be higher than zero");
        }
    }
}
