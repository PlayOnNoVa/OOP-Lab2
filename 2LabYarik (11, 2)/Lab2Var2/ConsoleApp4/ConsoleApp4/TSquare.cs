using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{

    class TSquare
    {
        static Random rnd = new Random();
        protected double side;

        public TSquare()
        {
            side = rnd.Next(1, 100);
        }
        public TSquare(double side)
        {
            this.side = side;
        }
        public TSquare(TSquare Square)
        {
            this.side = Square.side;
        }
        public override string ToString()
        {
            return  Convert.ToString(side);
        }



        public double Side
        {
            get { return side; }
            set { if (value > 0) side = value; }
        }
        public void GetArea()
        {
            double area;
            area = side * side;
            Console.WriteLine($"Square area: {area}");
        }
        public void GetPerimeter()
        {
            double squareSide;
            squareSide = side * 4;
            Console.WriteLine($"Square perimeter: {squareSide}");
        }

        public static void Compare(TSquare Square, TSquare Square2)
        {
            if (Square.side > Square2.side) { Console.WriteLine(Square.side + " > " + Square2.side + " on " + (Square.side - Square2.side)); }
            else if (Square.side < Square2.side) { Console.WriteLine(Square.side + " < " + Square2.side + " on " + (Square2.side - Square.side)); }
            else if (Square.side == Square2.side) { Console.WriteLine(Square.side + " = " + Square2.side);
            }


        }

        public static TSquare operator +(TSquare Square, TSquare Square2)
        {
            TSquare sum = new TSquare();
            sum.side = Square.side + Square2.side;
            return sum;
        }
        public static TSquare operator -(TSquare Square, TSquare Square2)
        {
            TSquare sum = new TSquare();
            sum.side = Math.Abs(Square.side - Square2.side);
            return sum;
        }
        public static TSquare operator *(TSquare Square, double n)
        {
            TSquare sum = new TSquare();
            sum.side = Square.side * n;
            return sum;
        }
        public static TSquare operator *(double n, TSquare Square)
        {
            TSquare sum = new TSquare();
            sum.side = n * Square.side;
            return sum;
        }
    }
}
