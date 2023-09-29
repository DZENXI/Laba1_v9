using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_v9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LineEquation equation = new LineEquation(-1, 2, 1);

            equation.PrintEquation();

            equation.A = 2;

            equation[1] = 5;

            Console.WriteLine(  );

            equation.PrintEquation();



            /*Console.WriteLine("enter x and y");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());*/

            double x = 0;
            double y = -0.5;

            bool pointOnLine = equation.IsPointOnLine(x, y);

            Console.WriteLine($"Point ({x}, {y}) {(pointOnLine ? "belongs to ": "does not belong to")} the line");

            //line intersect 

            Console.WriteLine("\n");

            LineEquation line1 = new LineEquation(2, 3, 5);
            LineEquation line2 = new LineEquation(4, 2, 6);


            line1.PrintEquation();
            line2.PrintEquation();

            Point intersection = line1.FindIntersection(line2);

            if (line1.A == line2.A && line1.B == line2.B && line1.C == line2.C)
            {
                Console.WriteLine("The lines are identical and have infinite intersection points.");

            }
            
            else if (intersection != null)
            {
                Console.WriteLine($"The lines intersect at a point ({intersection.X}, {intersection.Y})");
            }
            else 
            {
                Console.WriteLine("The lines do not intersect");
            }

            Console.WriteLine(  );

            Console.ReadKey();

        }
    }
}
