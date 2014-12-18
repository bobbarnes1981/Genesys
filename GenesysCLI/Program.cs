using System;
using GenesysLibrary;

namespace GenesysCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                int population;
                int generations;
                if (int.TryParse(args[1], out population) && int.TryParse(args[2], out generations))
                {
                    new Experiment(new Grid(args[0], 200), population, generations).Run();
                }
                else
                {
                    Usage();
                }
            }
            else
            {
                Usage();
            }
        }

        private static void Usage()
        {
            Console.WriteLine("Usage: GenesysCLI <filename> <population> <generations>");
        }
    }
}
