using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            int diffX = this.X - x;
            int diffY = this.Y - y;

            int squaredAddedXY = (diffX * diffX) + (diffY * diffY);

            int distance = (int)Math.Sqrt(squaredAddedXY);

            return distance;
        }

    }
}
