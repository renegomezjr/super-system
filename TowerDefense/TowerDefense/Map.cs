using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Map
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Map(int Height, int Width)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public bool OnMap(Point point)
        {
            bool inBounds = point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;

            return inBounds;
        }
    }
}
