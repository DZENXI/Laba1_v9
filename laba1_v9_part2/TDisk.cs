using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_v9_part2
{
    class TDisk
    {
        private double radius;
        private double xCenter;

        public TDisk()
        {

        }

        public TDisk(double radius, double center)
        {

            if (radius > 0 && center > 0)
            {
                this.radius = radius;
                this.xCenter = center;

            }
            else
            {
                Console.WriteLine("u entered not incorrect value");
            }

        }

        public TDisk(TDisk other)
        {
            this.radius = other.radius;
            this.xCenter = other.xCenter;

        }

        public override String ToString() 
        {
            return $"TDisk [radius = {radius} , center = {xCenter}]";
        }


        public double Radius
        {
            get { return radius; }
            set 
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    radius = 0;
                }
 
            }
        }

        public double XCenter
        {
            get { return xCenter; }
            set 
            {
                if (value > 0)
                {
                    xCenter = value;
                }
                else
                {
                    xCenter = 0;
                }
            }
        }


        public double СalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double СalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }


        
        public  double СalculateSecrotArea(double perimetr)
        {
            return (perimetr / 360) * Math.PI * Math.Pow(radius, 2);
        }

       public static bool operator == (TDisk first, TDisk other)
        {
            return (first.radius == other.radius && first.xCenter == other.xCenter) ? true : false;
        }
        public static bool operator != (TDisk first, TDisk other)
        {
            return (first.radius != other.radius && first.xCenter != other.xCenter) ? false : true;
        }
        //перегрузка
        public static TDisk operator *(TDisk obj, double multuplyer)
        {
            return new TDisk(obj.radius * multuplyer, obj.xCenter);
        }
        public static TDisk operator *(double multuplyer, TDisk obj)
        {
            return new TDisk(obj.radius * multuplyer, obj.xCenter);
        }


        // чи лежить точка на колі

        public bool IsPointInside(double x, double y)
        {
            return (Math.Sqrt(Math.Pow(x - xCenter, 2) + Math.Pow(y - 0, 2))) <= radius;
        }





    }
}