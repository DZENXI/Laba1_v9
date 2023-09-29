using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_v9_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Disc
            TDisk disk1 = new TDisk(5, 10);
            TDisk disk2 = new TDisk(6, 10);


            Console.WriteLine("disk1 " + disk1);

            //redefinition

            Console.WriteLine("перевантаження");

            disk2 = disk1 * 2;

            //comparing two circle

            Console.WriteLine("disc2 " + disk2);

            Console.WriteLine($"\nequality of two discs \n{disk1}\n{disk2}");
            
            if (disk1 == disk2)
            {
                Console.WriteLine("This disc is equal\n");
            }
            else 
            {
                Console.WriteLine("This disc is not qual\n");
            }

            if (disk1 != disk2)
            {
                Console.WriteLine("This disc is not equal\n");
            }
            else
            {
                Console.WriteLine("This disc is qual\n");
            }

            //point in the disk
            double x = 6, y = 10; //8, 3
            Console.WriteLine($"point have coordinater x = {x}, y = {y}");

            bool IsInside = disk1.IsPointInside(x, y);
            if (IsInside ) 
            {
                Console.WriteLine($"point {x}, {y} pint belongs to the circle");
            }
            else
            {
                Console.WriteLine($"point {x}, {y} pint does not belongs to the circle");

            }

            Console.WriteLine("\nradius = " + disk1.Radius);
            Console.WriteLine("center = " + disk1.XCenter);
            Console.WriteLine($"area = " + disk1.СalculateArea());
            Console.WriteLine("perimetr = " + disk1.СalculatePerimeter());
            Console.WriteLine();

            //Ball

            TBall ball = new TBall(4, 5, 10);

            Console.WriteLine("Ball");
            Console.WriteLine("radius = " + ball.Radius);
            Console.WriteLine("center = " + ball.XCenter + ", "+ ball.zCenter);
            Console.WriteLine("Value = " + ball.calculateVolume());
            
            try
            {
                double area = ball.СalculateArea();

                double perimeter = ball.СalculatePerimeter();

            }
            catch (InvalidOperationException ex)
            {

                Console.WriteLine(ex.Message);
            }

            //comparing two layer

            double z = 10;

            Console.WriteLine($"point have coordinater x = {x}, y = {y}, z = {z}");

            bool IsInsideBall = ball.IsPointInside(x, y, z);
            if (IsInsideBall)
            {
                Console.WriteLine($"point {x}, {y}, {z} pint belongs to the layer");
            }
            else
            {
                Console.WriteLine($"point {x}, {y}, {z} pint does not belongs to the layer");

            }




            Console.ReadKey();

        }
    }
}
