namespace GenesysLibrary
{
    public interface IAnt
    {
        Genome Genes { get; }
        Action ProcessInput(bool input);
        IAnt Mate(IAnt mate, double crossover, double mutation);
    }
}
