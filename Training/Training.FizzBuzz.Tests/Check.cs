using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training.FizzBuzz.Business;

namespace Training.FizzBuzz.Tests
{
    [TestClass]
    public class Check
    {
        [TestMethod]
        public void ItExists()
        {
            var fizzbuzz = new FizzBuzzApp();

            var result = fizzbuzz.Check(0);

            Assert.AreEqual("FizzBuzz", result);
        }

        /// Write the rests of the tests to get 100% coverage of
        /// what the Check method does.
        /// 1: For any input divisible by 3 return Fizz
        /// 2: For any input divisible by 5 return Buzz
        /// 3: For any input divisible by 3 and 5 return FizzBuzz
        /// 4: For all other inputs return the number that was input
    }
}
