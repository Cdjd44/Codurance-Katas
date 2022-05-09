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
        public void convert_1_to_1()
        {
            Assert.AreEqual("1", new FizzBuzz().convert(1));
        }

        [TestMethod]
        public void convert_2_to_2()
        {
            Assert.AreEqual("2", new FizzBuzz().convert(2));
        }

        [TestMethod]
        public void convert_4_to_4()
        {
            Assert.AreEqual("4", new FizzBuzz().convert(4));
        }

        [TestMethod]
        public void convert_number_to_FizzBuzz_string()
        {
            Dictionary<string, int> testNumbers = new Dictionary<string, int>();

            //initialise test numbers
            for(int i = 1; i < 15; i++)
            {
                testNumbers.Add(i.ToString(), i);
            }

        }
    }
}
