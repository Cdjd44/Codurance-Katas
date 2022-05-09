using Kata1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace Kata1_Tests
{
    [TestClass]
    public class FizzBuzzShould
    {
        [TestMethod]
        public void convert_number_to_FizzBuzz_string()
        {
            Dictionary<string, int> testNumbers = new Dictionary<string, int>();

            for(int i = 1; i < 4; i++)
            {
                if(i % 3 == 0 || i % 5 == 0) { continue; }
                Assert.AreEqual(i.ToString(), new FizzBuzz().convert(i));
            }
        }

        [TestMethod]
        public void convert_3_to_Fizz()
        {
            Assert.AreEqual("Fizz", new FizzBuzz().convert(3));
        }

        [TestMethod]
        public void convert_5_to_Buzz()
        {
            Assert.AreEqual("Buzz", new FizzBuzz().convert(5));
        }

        [TestMethod]
        public void convert_15_to_FizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", new FizzBuzz().convert(15));
        }
    }
}
