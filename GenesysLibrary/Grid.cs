using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenesysLibrary
{
    public class Grid : ICloneable
    {
        private bool[,] data;

        public int X
        {
            get
            {
                return this.data.GetLength(0);
            }
        }

        public int Y
        {
            get
            {
                return this.data.GetLength(1);
            }
        }

        public Grid(Grid grid)
        {
            this.data = new bool[grid.X, grid.Y];

            for (int y = 0; y < grid.Y; y++)
            {
                for (int x = 0; x < grid.X; x++)
                {
                    data[x, y] = grid.GetLocation(x, y);
                }
            }
        }

        public Grid(string path)
        {
            string[] source = File.ReadAllLines(path);

            this.data = new bool[source[0].Length, source.Length];

            for (int y = 0; y < source.Length; y++)
            {
                for (int x = 0; x < source[y].Length; x++)
                {
                    data[x, y] = source[y][x] == 'O';
                }
            }
        }

        public bool GetLocation(Location location)
        {
            return this.GetLocation(location.X, location.Y);
        }

        private bool GetLocation(int x, int y)
        {
            return this.data[x, y];
        }

        public void SetLocation(Location location, bool state)
        {
            this.SetLocation(location.X, location.Y, state);
        }

        private void SetLocation(int x, int y, bool state)
        {
            this.data[x, y] = state;
        }

        public object Clone()
        {
            return new Grid(this);
        }
    }
}
