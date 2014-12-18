using System;

namespace GenesysLibrary
{
    public class GenerationCompleteEventArgs : EventArgs
    {
        public int Generation { get; private set; }

        public int MaxScore { get; private set; }

        public GenerationCompleteEventArgs(int generation, int maxScore)
        {
            Generation = generation;
            MaxScore = maxScore;
        }
    }
}
