using System;

namespace GenesysLibrary
{
    public class Breeder
    {
        private static Random m_random = new Random();

        private Grid m_grid;

        private double m_crossover = 0.50;

        private double m_mutation = 0.05;

        private double m_percentage = 0.1;

        public Breeder(Grid grid, double crossover, double mutation, double percentage)
        {
            m_grid = grid;
            m_crossover = crossover;
            m_mutation = mutation;
            m_percentage = percentage;
        }

        public Tracker[] InitialPopulation(int size)
        {
            Tracker[] tasks = new Tracker[size];

            for (int i = 0; i < size; i++)
            {
                // TODO: accept <T> where T : IAnt, new() and do new T().Load(Genome.Random) or something
                tasks[i] = new Tracker(m_grid, AntFSA.Random());
            }

            return tasks;
        }

        public Tracker[] Breed(Tracker[] tasks)
        {
            int numberToBreed = (int)(tasks.Length * m_percentage);

            Console.Write("Top {0} scores:", numberToBreed);
            for (int i = 0; i < numberToBreed; i++)
            {
                Console.Write("{0},", tasks[i].Score);
            }
            Console.WriteLine();

            Tracker[] newTasks = new Tracker[tasks.Length];

            for (int j = 0; j < newTasks.Length; j++)
            {
                Tracker taskA = tasks[m_random.Next(0, numberToBreed)];
                Tracker taskB;
                do
                {
                    taskB = tasks[m_random.Next(0, numberToBreed)];
                } while (taskA == taskB);
                IAnt ant = taskA.Ant.Mate(taskB.Ant, m_crossover, m_mutation);
                newTasks[j] = new Tracker(m_grid, ant);
            }
            return newTasks;
        }
    }
}
