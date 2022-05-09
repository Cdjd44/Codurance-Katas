using Kata2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata2_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Is_Not_Leap_Year()
        {
            Assert.AreEqual(false, new Year().IsLeap(1997));
        }

        [TestMethod]
        public void Is_Not_Leap_Year_if_Divisable_by_100_but_not_400()
        {
            Assert.AreEqual(false, new Year().IsLeap(1800));
        }

        [TestMethod]
        public void Is_Leap_Year_if_Divisable_by_4()
        {
            Assert.AreEqual(true, new Year().IsLeap(1996));
        }

        [TestMethod]
        public void Is_Leap_Year_if_Divisable_by_400()
        {
            Assert.AreEqual(true, new Year().IsLeap(1600));
        }

        
    }
}
