using Ex_09_03; // for Ex_09_03 code
using Microsoft.VisualStudio.TestTools.UnitTesting; // for Test and Assert
using System; // for DivideByZeroException
namespace Ex_09_03_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DivideTest()
        {
            double expected = 1.2857;
            double obtained = Program.Divide(9, 7);
            Assert.AreEqual(expected, obtained, 0.0001, "Results don't match.");
            Assert.ThrowsException<DivideByZeroException>(() => Program.Divide(9, 0));
        }
        [TestMethod]
        public void CompareTest()
        {
            bool result = Program.Compare(0, 1);
            Assert.IsFalse(result);
        }
    }
}