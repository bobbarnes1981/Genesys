using System;

namespace GenesysLibrary
{
    public class TaskEvaluatedEventArgs : EventArgs
    {
        public int Task { get; private set; }

        public int Score { get; private set; }

        public TaskEvaluatedEventArgs(int task, int score)
        {
            Task = task;
            Score = score;
        }
    }
}
