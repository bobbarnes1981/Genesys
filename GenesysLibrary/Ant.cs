﻿namespace GenesysLibrary
{
    public abstract class Ant : IAnt
    {
        public Genome Genes { get; private set; }
        
        protected Ant(Genome genes)
        {
            Genes = genes;
        }

        public abstract Action ProcessInput(bool input);
        
        public IAnt Mate(IAnt mate, double crossover, double mutation)
        {
            return new AntFSA(Genes.Combine(mate.Genes, crossover, mutation));
        }
    }
}
