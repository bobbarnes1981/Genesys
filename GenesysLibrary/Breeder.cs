using System;

namespace GenesysLibrary
{
    public class Breeder
    {
        private static Random m_random = new Random();

        public IAntFactory AntFactory = new AntFSAFactory();

        private Grid m_grid;

        private decimal m_crossover = 0.50m;

        private decimal m_mutation = 0.05m;

        private decimal m_percentage = 0.1m;

        public Breeder(Grid grid, decimal crossover, decimal mutation, decimal percentage)
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
                tasks[i] = new Tracker(m_grid, AntFactory.Generate());
            }

            return tasks;
        }

        public Tracker[] Breed(Tracker[] tasks)
        {
            int numberToBreed = (int)(tasks.Length * m_percentage);

            Tracker[] newTasks = new Tracker[tasks.Length];

            for (int j = 0; j < newTasks.Length; j++)
            {
                Tracker taskA = tasks[m_random.Next(0, numberToBreed)];
                Tracker taskB;
                do
                {
                    taskB = tasks[m_random.Next(0, numberToBreed)];
                } while (taskB == taskA);
                IAnt ant = taskA.Ant.Mate(taskB.Ant, m_crossover, m_mutation);
                newTasks[j] = new Tracker(m_grid, ant);
            }
            return newTasks;
        }
    }
}
