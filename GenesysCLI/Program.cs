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
                    Grid grid = new Grid(args[0], 200);
                    Breeder breeder = new Breeder(grid, 0.5m, 0.05m, 0.1m);
                    new Experiment(breeder, population).Run(generations);
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
