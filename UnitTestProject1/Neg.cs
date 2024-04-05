using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class Neg
    {
        [TestMethod]
        public void TestMethod1()
        {

            Assert.IsFalse(MainWindow.task("10", "10", "10", "10"));
            Assert.IsFalse(MainWindow.task("1.5", "1", "1", "1"));
            Assert.IsFalse(MainWindow.task("10", "dfsd", "20", "9"));
            Assert.IsFalse(MainWindow.task(" ", " ", "1", "1"));
            Assert.IsFalse(MainWindow.task("10", "800", "30", "10"));
        }
    }
}
