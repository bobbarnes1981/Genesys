using GenesysLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenesysLibraryTests
{
    [TestClass]
    public class AntTests
    {
        [TestMethod]
        public void CheckAnt42Scores42()
        {
            Grid grid = new Grid(@"..\..\..\Files\JohnMuirTrail.grid", 200);
            IAnt ant = AntFSA.Ant42;
            Tracker tracker = new Tracker(grid, ant);
            tracker.Evaluate();
            Assert.AreEqual(42, tracker.Score);
        }

        [TestMethod]
        public void CheckAnt81Scores81()
        {
            Grid grid = new Grid(@"..\..\..\Files\JohnMuirTrail.grid", 200);
            IAnt ant = AntFSA.Ant81;
            Tracker tracker = new Tracker(grid, ant);
            tracker.Evaluate();
            Assert.AreEqual(81, tracker.Score);
        }
    }
}
