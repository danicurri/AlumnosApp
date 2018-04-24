using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{   // The abstract base class of the hierarchy(you don’t want to allow the object user
    //to create an instance of Shape directly, as it is too abstract of a concept)
    abstract class Shape
    {
        public Shape(string name = "NoName");
        { PetName = name; }
    
        public string PetName { get; set; }
    // A single virtual method.
        public abstract void Draw()
    {
        Console.WriteLine("Inside Shape.Draw() "); //given that you want the derived types to respond uniquely to the Draw() method, let’s mark it as virtual
    }
    }
}
