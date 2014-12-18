namespace GenesysLibrary
{
    public class AntFSAFactory : IAntFactory
    {
        public IAnt Generate()
        {
            return new AntFSA(Genome.Random(AntFSA.GENOME_LENGTH));
        }
    }
}
