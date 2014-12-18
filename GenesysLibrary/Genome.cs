using System;
using System.Collections;
using System.Text;

namespace GenesysLibrary
{
    public class Genome
    {
        private static Random m_random = new Random();

        private BitArray m_genes;

        public Genome(Genome genes)
        {
            m_genes = new BitArray(genes.Length);
            for (int i = 0; i < m_genes.Length; i++)
            {
                m_genes[i] = genes.m_genes[i];
            }
        }

        public Genome(string input)
        {
            m_genes = new BitArray(input.Length, false);
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '0':
                        m_genes[i] = false;
                        break;
                    case '1':
                        m_genes[i] = true;
                        break;
                    default:
                        throw new Exception(string.Format("Invalid gene {0} at {1} ", input[i], i));
                }
            }
        }

        public int Length { get { return m_genes.Length; }}

        public static Genome Random(int length)
        {
            StringBuilder genes = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                genes.Append(m_random.NextDouble() < 0.50 ? "0" : "1");
            }
            return new Genome(genes.ToString());
        }

        public int GetInt(int offset, int length)
        {
            int result = 0;
            int increment = 1;
            for (int i = length - 1; i > -1; i--)
            {
                if (m_genes[offset + i])
                {
                    result += increment;
                }
                increment *= 2;
            }
            return result;
        }

        public Genome Combine(Genome that, double crossover, double mutation)
        {
            if (m_genes.Length != that.m_genes.Length)
            {
                throw new Exception("incompatible genomes");
            }
            Genome genes = new Genome(this);
            for (int i = 0; i < genes.Length; i++)
            {
                // crossover
                if (m_random.NextDouble() < crossover)
                {
                    genes.m_genes[i] = m_genes[i];
                }
                else
                {
                    genes.m_genes[i] = that.m_genes[i];
                }
                // point mutation
                if (m_random.NextDouble() < mutation)
                {
                    genes.m_genes[i] = !genes.m_genes[i];
                }
            }
            return genes;
        }

        public Genome Copy()
        {
            return new Genome(this);
        }
    }
}
