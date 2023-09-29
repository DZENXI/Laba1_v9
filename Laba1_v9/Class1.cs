using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_v9
{
    internal class LineEquation
    {
        private double a;
        private double b;
        private double c;

        public LineEquation(double a, double b, double c)
        {
            if (a >= 0 && b >= 0 & c >= 0)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else { Console.WriteLine("incoterct values"); }
        }


        public double this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return a;

                }
                else if (index == 1)
                {
                    return b;

                }
                else if (index == 2)
                {
                    return c;
                }
                else
                    throw new IndexOutOfRangeException("index is out of range, choice 0, 1 or 2");
            }


            set
            {

                if (index == 0)
                {
                    a = value;

                }
                else if (index == 1)
                {
                    b = value;

                }
                else if (index == 2)
                {
                    c = value;
                }
                else
                    throw new IndexOutOfRangeException("index is out of range, choice 0, 1 or 2");
            }
        }


        public double A
        {

            get { return a; }
            set 
            {
                if (value > 0)
                {
                    a = value;
                }
                else
                {
                    a = 0;
                }
            }
        }

        public double B
        {
            get { return b; }
            set 
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    b = 0;
                }
            }
        }

        public double C
        {
            get { return c; }
            set 
            {
                if (value > 0)
                {
                    c = value;
                }
                else
                {
                    c = 0;
                }
            }
        }

        public void PrintEquation()
        {
            Console.WriteLine($"{a}x + {b}y + {c} = 0");
        }

        public bool IsPointOnLine(double x, double y)
        {
            double result = a * x + b * y + c;
            return Math.Abs(result) < double.Epsilon;
        }


        public Point FindIntersection(LineEquation otherLine)
        {
            if (this.A == otherLine.A && this.B == otherLine.B && this.C == otherLine.C)
            {

                return new Point(0, 0);
            }

            double determinant = this.A * otherLine.B - otherLine.A * this.B;

            if (Math.Abs(determinant) < double.Epsilon)
            {

                return null;
            }

            double x = (otherLine.C * this.B - this.C * otherLine.B) / determinant;
            double y = (this.C * otherLine.A - otherLine.C * this.A) / determinant;

            return new Point(x, y);
        }


    }
}
