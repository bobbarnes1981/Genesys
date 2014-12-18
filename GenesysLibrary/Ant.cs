using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenesysLibrary
{
    // genes
    // first 5 = start location

    // multiples of:
    // new state for 0 input (5 bits) action (2 bits)
    // new state for 1 input (5 bits) action (2 bits)

    // 32 states

    // (14*32)+5 = 453


    //   N
    // W   E
    //   S

    // 0,0 ->
    // |
    // V

    public class Ant : IComparable
    {
        public static readonly Ant Ant41 = new Ant("0000000000010000111000010100011110001010000111100010100001011");
        public static readonly Ant Ant81 = new Ant("000000000110000001100010100000011000111000000110010010000001100000110000011");

        private const int genomeLength = 453;

        private static Random random = new Random();
        private double crossover = 0.50;
        private double pointMutation = 0.05;

        private int m_currentState;

        private Location m_location;

        private Direction m_currentDirection;

        private BitArray m_genes;

        private int m_score;

        public int Score
        {
            get
            {
                return m_score;
            }
        }

        public static BitArray GenesFromString(string genesString)
        {
            BitArray genes = new BitArray(genomeLength, false);
            for (int g = 0; g < genesString.Length; g++)
            {
                switch (genesString[g])
                {
                    case '0':
                        genes[g] = false;
                        break;
                    case '1':
                        genes[g] = true;
                        break;
                    default:
                        throw new Exception("invalid gene: " + genesString[g]);
                }
            }
            return genes;
        }

        public static Ant CreateRandom()
        {
            BitArray genes = new BitArray(genomeLength);
            for (int g = 0; g < genes.Length; g++)
            {
                genes[g] = Ant.random.NextDouble() < 0.50;
            }
            return new Ant(genes);
        }

        private int ReadGenes(int startLocation, int length)
        {
            int result = 0;
            int increment = 1;
            for (int i = length - 1; i > -1; i--)
            {
                if (m_genes[startLocation + i])
                {
                    result += increment;
                }
                increment *= 2;
            }
            return result;
        }

        protected Ant(BitArray genes)
        {
            m_location = new Location(0, 0);
            m_currentDirection = Direction.East;
            m_genes = genes;
            m_currentState = ReadGenes(0, 5);
        }

        protected Ant(string genesString)
            : this(Ant.GenesFromString(genesString))
        {
        }

        /// <summary>
        /// Get the action and move to next state
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private Action GetAction(int state, bool input)
        {
            return (Action)ReadGenes(((state) * 14) + (input ? 7 : 0) + 5 + 5, 2); ;
        }

        private int GetNextState(int state, bool input)
        {
            return ReadGenes(((state) * 14) + (input ? 7 : 0) + 5, 5);
        }

        private bool GetInput(Grid grid)
        {
            Location inputLocation = new Location(m_location.X, m_location.Y);
            switch (m_currentDirection)
            {
                case Direction.North:
                    inputLocation.Y -= 1;
                    break;
                case Direction.East:
                    inputLocation.X += 1;
                    break;
                case Direction.South:
                    inputLocation.Y += 1;
                    break;
                case Direction.West:
                    inputLocation.X -= 1;
                    break;
            }
            inputLocation = FixGridReferences(grid, inputLocation);
            return grid.GetLocation(inputLocation);
        }

        private Action Process(bool input)
        {
            int lastState = m_currentState;
            Action action = GetAction(lastState, input);
            m_currentState = GetNextState(lastState, input);
            return action;
        }

        private Location FixGridReferences(Grid grid, Location location)
        {
            if (location.X < 0)
            {
                location.X = grid.X - 1;
            }
            if (location.Y < 0)
            {
                location.Y = grid.Y - 1;
            }
            if (location.X > grid.X - 1)
            {
                location.X = 0;
            }
            if (location.Y > grid.Y - 1)
            {
                location.Y = 0;
            }
            return location;
        }

        public void Evaluate(Grid grid, int stepLimit)
        {
            for (int i = 0; i < stepLimit; i++)
            {
                switch (Process(GetInput(grid)))
                {
                    case Action.Forward:
                        Forward(grid);
                        break;
                    case Action.Left:
                        Left();
                        break;
                    case Action.Nothing:
                        break;
                    case Action.Right:
                        Right();
                        break;
                }
            }
            //Console.WriteLine("{0}", score);
        }

        private void Forward(Grid grid)
        {
            switch (m_currentDirection)
            {
                case Direction.North:
                    m_location.Y -= 1;
                    break;
                case Direction.East:
                    m_location.X += 1;
                    break;
                case Direction.South:
                    m_location.Y += 1;
                    break;
                case Direction.West:
                    m_location.X -= 1;
                    break;
            }
            m_location = FixGridReferences(grid, m_location);
            if (grid.GetLocation(m_location))
            {
                m_score++;
                grid.SetLocation(m_location, false);
            }
        }

        private void Left()
        {
            switch (m_currentDirection)
            {
                case Direction.North:
                    m_currentDirection = Direction.West;
                    break;
                case Direction.East:
                    m_currentDirection = Direction.North;
                    break;
                case Direction.South:
                    m_currentDirection = Direction.East;
                    break;
                case Direction.West:
                    m_currentDirection = Direction.South;
                    break;
            }
        }

        private void Right()
        {
            switch (m_currentDirection)
            {
                case Direction.North:
                    m_currentDirection = Direction.East;
                    break;
                case Direction.East:
                    m_currentDirection = Direction.South;
                    break;
                case Direction.South:
                    m_currentDirection = Direction.West;
                    break;
                case Direction.West:
                    m_currentDirection = Direction.North;
                    break;
            }
        }

        /// <summary>
        /// mate with the provided ant
        /// </summary>
        /// <param name="mate"></param>
        /// <returns></returns>
        public Ant Mate(Ant mate)
        {
            BitArray genes = new BitArray(m_genes.Length);
            for (int g = 0; g < genes.Length; g++)
            {
                // crossover
                if (Ant.random.NextDouble() < crossover)
                {
                    genes[g] = genes[g];
                }
                else
                {
                    genes[g] = mate.m_genes[g];
                }
                // point mutation
                if (Ant.random.NextDouble() < pointMutation)
                {
                    genes[g] = !genes[g];
                }
            }
            return new Ant(genes);
        }

        public string StateTransitionTable()
        {
            // draw state transition table
            string output = string.Empty;

            output += string.Format("Initial State: {0}\r\n", ReadGenes(0, 5));
            output += "state\t|input\t|newstate\t|action\r\n";
            for (int i = 0; i < 32; i++)
            {
                output += string.Format("{0}\t|{1}\t|{2}\t|{3}\r\n", i, false, GetNextState(i, false), GetAction(i, false));
                output += string.Format("{0}\t|{1}\t|{2}\t|{3}\r\n", i, true, GetNextState(i, true), GetAction(i, true));
            }
            return output;
        }

        public int CompareTo(object that)
        {
            if (that == null || that.GetType() != typeof(Ant))
            {
                return -1;
            }

            return m_score.CompareTo(((Ant)that).m_score);
        }
    }
}
