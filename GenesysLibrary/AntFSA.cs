namespace GenesysLibrary
{
    /// <summary>
    /// Finite State Automata ant using state transition table.
    /// Genome is:
    /// first 5 bits = initial state
    /// multiples of:
    /// new state for 0 input (5 bits) action (2 bits)
    /// new state for 1 input (5 bits) action (2 bits)
    /// 32 states
    /// (14*32)+5 = 453
    /// </summary>
    public class AntFSA : Ant
    {
        public static readonly AntFSA Ant42 = new AntFSA(new Genome("000000000001000011100001010001111000101000011110001010000101100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"));
        public static readonly AntFSA Ant81 = new AntFSA(new Genome("000000000110000001100010100000011000111000000110010010000001100000110000011000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"));

        private const int GENOME_LENGTH = 453;

        private int m_state;
        
        public AntFSA(Genome genes)
            : base(genes)
        {
            m_state = Genes.GetInt(0, 5);
        }

        public static AntFSA Random()
        {
            return new AntFSA(Genome.Random(GENOME_LENGTH));
        }

        public override Action ProcessInput(bool input)
        {
            Action action = ActionFromGenome(m_state, input);
            m_state = StateFromGenome(m_state, input);
            return action;
        }
        
        private Action ActionFromGenome(int state, bool input)
        {
            return (Action)Genes.GetInt(((state) * 14) + (input ? 7 : 0) + 5 + 5, 2);
        }

        private int StateFromGenome(int state, bool input)
        {
            return Genes.GetInt(((state) * 14) + (input ? 7 : 0) + 5, 5);
        }

        public override string ToString()
        {
            string output = string.Empty;

            output += string.Format("Initial State: {0}\r\n", Genes.GetInt(0, 5));
            output += "state\t|input\t|newstate\t|action\r\n";
            for (int i = 0; i < 32; i++)
            {
                output += string.Format("{0}\t|{1}\t|{2}\t|{3}\r\n", i, false, StateFromGenome(i, false), ActionFromGenome(i, false));
                output += string.Format("{0}\t|{1}\t|{2}\t|{3}\r\n", i, true, StateFromGenome(i, true), ActionFromGenome(i, true));
            }
            return output;
        }
    }
}
