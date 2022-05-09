using Kata2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata2_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Is_Leap_Year()
        {
            Assert.AreEqual(true, new Year().IsLeap(2016));
        }
    }
}
