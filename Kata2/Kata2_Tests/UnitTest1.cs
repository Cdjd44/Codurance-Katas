using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata2_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void number_is_divisable_by_4()
        {
            var year = new Year(2006);
            Assert.AreEqual(year.IsLeap(), Is.True);
        }
    }
}
