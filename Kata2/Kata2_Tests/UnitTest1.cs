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
            Year year = new Year(1997);
            Assert.AreEqual(false, year.IsLeap());
        }

        [TestMethod]
        public void Is_Not_Leap_Year_if_Divisable_by_100_but_not_400()
        {
            Year year = new Year(1800);
            Assert.AreEqual(false, year.IsLeap());
        }

        [TestMethod]
        public void Is_Leap_Year_if_Divisable_by_4()
        {
            Year year = new Year(1996);
            Assert.AreEqual(true, year.IsLeap());
        }

        [TestMethod]
        public void Is_Leap_Year_if_Divisable_by_400()
        {
            Year year = new Year(1600);
            Assert.AreEqual(true, year.IsLeap());
        }

        
    }
}
