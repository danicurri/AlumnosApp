using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    class BitmapImage : IAdvancedDraw
    {
        public void Draw()
        {
            Console.WriteLine("Drawing...");

        public void DrawInBoundingBox(int top, int left, int bottom, int right)
        {
                Console.WriteLine("Drawing in box...");
        }

        public void DrawUpSideDown()
        {
                Console.WriteLine("Drawing upside down...");
        }
    }
}
