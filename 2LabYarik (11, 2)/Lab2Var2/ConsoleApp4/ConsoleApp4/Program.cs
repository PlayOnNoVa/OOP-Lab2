using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            TSquare Square = new TSquare();
            TSquare Square2 = new TSquare();

            Console.WriteLine("Side of Square equals: " + Square);
            Console.WriteLine("Side of Square2 equals: " + Square2);
            Console.WriteLine();
            Square.GetArea();
            Square.GetPerimeter();
            TSquare.Compare(Square, Square2);

            Square2.GetArea();
            Square2.GetPerimeter();

            Console.WriteLine("Sum of squares " + (Square + Square2));

            Console.WriteLine();


            TCube cube = new TCube();
            Console.WriteLine("Side of cube equals: "+ cube);
            cube.Volume();

        }
    }
}
