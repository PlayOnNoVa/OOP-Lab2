using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class TCube : TSquare
    {
        static Random rnd = new Random();

        public void Volume()
        {
            double volume = side * side * side;
            Console.WriteLine();
            Console.WriteLine("Cube Volume: " + volume);
        }
            

        public TCube()
        {
            side = rnd.Next(1, 100);
        }
        public TCube(double side, double height)
        {
            this.side = side;
        }

        public TCube(TCube TCube)
        {
            this.side = TCube.side;

        }

        public override string ToString()
        {
            return Convert.ToString(side);
        }
    }
}
