using System;

namespace Lab_2
{
    public class Equations
    {
        public double a, b, c, d, e, f;
        public double x, y;
        public Equations()
        {
            PrintAll();
        }
        public virtual void Value()
        {
            Console.Write("Enter Value (a1): ");
            double a = double.Parse(Console.ReadLine());
            this.a = a;
            Console.Write("Enter Value (b1): ");
            double b = double.Parse(Console.ReadLine());
            this.b = b;
            Console.Write("Enter Value (c1): ");
            double c = double.Parse(Console.ReadLine());
            this.c = c;
            Console.Write("Enter Value (a2): ");
            double d = double.Parse(Console.ReadLine());
            this.d = d;
            Console.Write("Enter Value (b2): ");
            double e = double.Parse(Console.ReadLine());
            this.e = e;
            Console.Write("Enter Value (c2): ");
            double f = double.Parse(Console.ReadLine());
            this.f = f;

        }
        public void PrintAll()
        {
            Value();

            Console.WriteLine();

            Console.WriteLine("A system of equations:");
            Console.WriteLine("{0}x+{1}y={2}", a, b, c);
            Console.WriteLine("{0}x+{1}y={2}", d, e, f);

            Console.WriteLine();

            Console.WriteLine("Solution:");
            Solution(a, b, c, d, e, f, x, y);
        }

        public static void Solution(double a, double b, double c, double d, double e, double f, double x, double y)
        {
             x = (c * e - b * f) / (a * e - b * d);
             y = (a * f - c * d) / (a * e - b * d);

            Console.WriteLine("\nX = " + x + "; Y = " + y);

            if((a*x+b*y==c)&&(d * x + e * y ==f))
            {
                Console.WriteLine("A point is a solution of a system of equations.");
            }
            else
            { Console.WriteLine("A point isn't a solution of a system of equations."); }

        }
       
    }
}