using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_v9_part2
{
    class TBall : TDisk
    {
        public double zCenter;

        public TBall(double radius, double xCenter, double zCenter)
           : base (radius, xCenter)
        {
            this.zCenter = zCenter;
        }

        //новий ту стрінг

        public override String ToString()
        {
            return $"TBall [radius = {Radius}, center = ({XCenter}, {zCenter})]";
        }


        public double ZCenter
        {
            get { return zCenter; }
            set { zCenter = value; }
        }
        public double calculateVolume()
        {
            return (3.0 / 4.0) * Math.PI * Math.Pow(Radius, 3);
        }


        public double СalculateArea()
        {
            throw new InvalidOperationException("\n а так не можна\n");
        }

        public double СalculatePerimeter()
        {
            throw new InvalidOperationException("\n а так не можна\n");
        }
        public bool IsPointInside(double x, double y, double z)
        {
            return (Math.Sqrt(Math.Pow(x - XCenter, 2) + Math.Pow(y - ZCenter, 2) + Math.Pow(z - ZCenter, 2))) <= Radius;
        }

    }
}
