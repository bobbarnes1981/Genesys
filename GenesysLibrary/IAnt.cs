namespace GenesysLibrary
{
    public interface IAnt
    {
        Genome Genes { get; }
        Action ProcessInput(bool input);
        IAnt Mate(IAnt mate, decimal crossover, decimal mutation);
    }
}
