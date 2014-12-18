using System;

namespace GenesysLibrary
{
    public class Experiment
    {
        private Grid m_grid;

        private int m_population;
        
        private Breeder m_breeder;

        private Tracker[] m_tasks;

        private bool m_running = false;

        public event EventHandler<GenerationCompleteEventArgs> GenerationCompleteHandler;

        public event EventHandler<TaskEvaluatedEventArgs> TaskEvaluatedHandler;

        public event EventHandler<StatusChangedEventArgs> StatusChangedHandler;

        public Experiment(Breeder breeder, int population)
        {
            m_breeder = breeder;
            m_population = population;
        }

        public void Run(int generations)
        {
            onStatusChanged("Spawning");
            
            m_tasks = m_breeder.InitialPopulation(m_population);

            m_running = true;

            onGenerationComplete(0, 0);

            for (int g = 0; g < generations; g++)
            {
                for (int t = 0; t < m_tasks.Length; t++)
                {
                    m_tasks[t].Evaluate();
                    onTaskEvaluated(t+1, m_tasks[t].Score);
                }

                Array.Sort(m_tasks);

                Array.Reverse(m_tasks);

                if (!m_running)
                {
                    break;
                }

                onGenerationComplete(g + 1, m_tasks[0].Score);

                if (g < generations - 1)
                {
                    onStatusChanged("Breeding");
                    m_tasks = m_breeder.Breed(m_tasks);
                }
            }
        }

        public void Stop()
        {
            m_running = false;
        }

        private void onGenerationComplete(int generation, int maxScore)
        {
            if (GenerationCompleteHandler != null)
            {
                GenerationCompleteHandler(this, new GenerationCompleteEventArgs(generation, maxScore));
            }
        }

        private void onTaskEvaluated(int task, int score)
        {
            if (TaskEvaluatedHandler != null)
            {
                TaskEvaluatedHandler(this, new TaskEvaluatedEventArgs(task, score));
            }
        }

        private void onStatusChanged(string text)
        {
            if (StatusChangedHandler != null)
            {
                StatusChangedHandler(this, new StatusChangedEventArgs(text));
            }
        }
    }
}
