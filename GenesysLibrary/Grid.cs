using System.IO;

namespace GenesysLibrary
{
    public class Grid
    {
        private bool[,] m_data;

        public int Limit { get; private set; }

        public int X
        {
            get
            {
                return m_data.GetLength(0);
            }
        }

        public int Y
        {
            get
            {
                return m_data.GetLength(1);
            }
        }

        public Grid(Grid grid)
        {
            Limit = grid.Limit;

            m_data = new bool[grid.X, grid.Y];

            for (int y = 0; y < grid.Y; y++)
            {
                for (int x = 0; x < grid.X; x++)
                {
                    m_data[x, y] = grid[x, y];
                }
            }
        }

        public Grid(string path, int limit)
        {
            Limit = limit;

            string[] source = File.ReadAllLines(path);

            m_data = new bool[source[0].Length, source.Length];

            for (int y = 0; y < source.Length; y++)
            {
                for (int x = 0; x < source[y].Length; x++)
                {
                    m_data[x, y] = source[y][x] == 'O';
                }
            }
        }

        public bool this[Location location]
        {
            get { return this[location.X, location.Y]; }
            set { this[location.X, location.Y] = value; }
        }

        private bool this[int x, int y]
        {
            get { return m_data[x, y]; }
            set { m_data[x, y] = value; }
        }

        public Grid Copy()
        {
            return new Grid(this);
        }
    }
}
