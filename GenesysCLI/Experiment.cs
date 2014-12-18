using System;
using GenesysLibrary;

namespace GenesysCLI
{
    public class Experiment
    {
        private Grid m_grid;

        private int m_population;

        private int m_generations;
        
        private Breeder m_breeder;

        public Experiment(Grid grid, int population, int generations)
        {
            m_grid = grid;
            m_population = population;
            m_generations = generations;

            m_breeder = new Breeder(m_grid, 0.5, 0.05, 0.1);
        }

        public void Run()
        {
            Tracker[] tasks = m_breeder.InitialPopulation(m_population);

            for (int g = 0; g < m_generations; g++)
            {
                foreach (Tracker task in tasks)
                {
                    task.Evaluate();
                }

                Array.Sort(tasks);

                Array.Reverse(tasks);

                Console.WriteLine("Generation: {0}", g);

                Console.WriteLine("Best score: {0}", tasks[0].Score);

                if (g < m_generations - 1)
                {
                    tasks = m_breeder.Breed(tasks);
                }
            }
        }
    }
}
