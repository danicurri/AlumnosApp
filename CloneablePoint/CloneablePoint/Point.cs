using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{ 
    // The Point now supports "clone-ability."
    public class Point : ICloneable
 
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point() { }

        // Override Object.ToString().
        public override string ToString() => $"X = {X}, Y = {Y}";

        // Return a copy of the current object.
        public Object Clone() => new Point(this.X, this.Y);
    }
}

