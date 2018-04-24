using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
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
        }
    }
}
