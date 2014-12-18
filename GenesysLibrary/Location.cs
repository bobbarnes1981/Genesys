namespace GenesysLibrary
{
    public class Location
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Location()
            : this(0, 0)
        {
        }

        public Location(Location location)
            : this(location.X, location.Y)
        {
        }

        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Location North
        {
            get { return new Location(X, Y - 1); }
        }

        public Location South
        {
            get { return new Location(X, Y + 1); }
        }

        public Location East
        {
            get { return new Location(X + 1, Y); }
        }

        public Location West
        {
            get { return new Location(X - 1, Y); }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", X, Y);
        }
    }
}
