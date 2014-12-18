using System;
using System.Collections.Generic;

namespace GenesysLibrary
{
    public class Tracker : IComparable
    {
        private Grid m_grid;

        public IAnt Ant { get; private set; }

        public int Score { get; private set; }

        private Location m_location;

        private Direction m_facing;

        private Dictionary<Direction, Direction> m_lDictionary = new Dictionary<Direction, Direction>
        {
            {Direction.North, Direction.West},
            {Direction.East, Direction.North},
            {Direction.South, Direction.East},
            {Direction.West, Direction.South},
        };

        private Dictionary<Direction, Direction> m_rDictionary = new Dictionary<Direction, Direction>
        {
            {Direction.North, Direction.East},
            {Direction.East, Direction.South},
            {Direction.South, Direction.West},
            {Direction.West, Direction.North},
        };

        public Tracker(Grid grid, IAnt ant)
        {
            m_grid = grid.Copy();
            Ant = ant;
            Score = 0;
            m_location = new Location(0, 0);
            m_facing = Direction.East;
        }

        public void Evaluate()
        {
            // TODO: needs to quit if scores maximum
            for (int i = 0; i < m_grid.Limit; i++)
            {
                bool input = GetInput();
                Action action = Ant.ProcessInput(input);
                switch (action)
                {
                    case Action.Forward:
                        Forward();
                        break;
                    case Action.Left:
                        m_facing = m_lDictionary[m_facing];
                        break;
                    case Action.Right:
                        m_facing = m_rDictionary[m_facing];
                        break;
                    case Action.Nothing:
                        break;
                }
            }
        }

        private bool GetInput()
        {
            Location source = new Location();
            switch (m_facing)
            {
                case Direction.North:
                    source = m_location.North;
                    break;
                case Direction.East:
                    source = m_location.East;
                    break;
                case Direction.South:
                    source = m_location.South;
                    break;
                case Direction.West:
                    source = m_location.West;
                    break;
            }
            source = WrapLocation(source);
            return m_grid[source];
        }

        private void Forward()
        {
            switch (m_facing)
            {
                case Direction.North:
                    m_location = m_location.North;
                    break;
                case Direction.East:
                    m_location = m_location.East;
                    break;
                case Direction.South:
                    m_location = m_location.South;
                    break;
                case Direction.West:
                    m_location = m_location.West;
                    break;
            }
            m_location = WrapLocation(m_location);
            if (m_grid[m_location])
            {
                Score++;
                m_grid[m_location] = false;
            }
        }

        private Location WrapLocation(Location location)
        {
            Location wrapped = new Location(location);
            if (wrapped.X < 0)
            {
                wrapped.X = m_grid.X - 1;
            }
            if (wrapped.Y < 0)
            {
                wrapped.Y = m_grid.Y - 1;
            }
            if (wrapped.X > m_grid.X - 1)
            {
                wrapped.X = 0;
            }
            if (wrapped.Y > m_grid.Y - 1)
            {
                wrapped.Y = 0;
            }
            return wrapped;
        }

        public int CompareTo(object obj)
        {
            if (obj.GetType() != typeof (Tracker))
            {
                return -1;
            }

            return Score.CompareTo(((Tracker) obj).Score);
        }
    }
}
