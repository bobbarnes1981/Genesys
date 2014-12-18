using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenesysLibrary
{
    public class Location
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Location(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", this.X, this.Y);
        }
    }
}
