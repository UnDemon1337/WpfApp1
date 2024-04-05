using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class Pos
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(MainWindow.task("10", "50", "30", "10"));
            Assert.IsTrue(MainWindow.task("1", "1", "1", "1"));
            Assert.IsTrue(MainWindow.task("10", "10", "10", "10"));
            Assert.IsTrue(MainWindow.task("5", "40", "10", "8"));
        }
    }
}
