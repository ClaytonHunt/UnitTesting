using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Training.StringCalculator.Business;

namespace Training.StringCalculator.Tests
{
    [TestClass]
    /// Create a simple String calculator with a method signature:
    /// ———————————————
    /// int Add(string numbers)
    /// ———————————————
    /// The method can take up to two numbers, separated by commas, and will return their sum.
    /// for example “” or “1” or “1,2” as inputs.
    /// (for an empty string it will return 0)
    /// Hints:
    /// ——————
    ///  - Start with the simplest test case of an empty string and move to one and two numbers
    ///  - Remember to solve things as simply as possible so that you force yourself to write tests you did not think about
    ///  - Remember to refactor after each passing test
    /// ———————————————————————————————
    /// Allow the Add method to handle an unknown amount of numbers
    /// ————————————————————————————————
    /// Allow the Add method to handle new lines between numbers (instead of commas).
    /// the following input is ok: “1\n2,3” (will equal 6)
    /// the following input is NOT ok: “1,\n” (not need to prove it - just clarifying)
    /// ——————————————————————————————-
    /// Support different delimiters
    /// to change a delimiter, the beginning of the string will contain a separate line that looks like this: “//[delimiter]\n[numbers…]” for example “//;\n1;2” should return three where the default delimiter is ‘;’ .
    /// the first line is optional. all existing scenarios should still be supported
    /// ————————————————————————————————
    /// Calling Add with a negative number will throw an exception “negatives not allowed” - and the negative that was passed. 
    /// if there are multiple negatives, show all of them in the exception message.
    public class Add
    {
        private StringCalculatorApp _calc;

        public Add()
        {
            _calc = new StringCalculatorApp();
        }

        [TestMethod]
        public void ItExists()
        {
            var result = _calc.Add("");

            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void AddSingleNumberReturnsNumber()
        {
            var result = _calc.Add("1");

            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void AddTwoNumbersReturnsSum()
        {
            var result = _calc.Add("1,2");

            Assert.AreEqual("3", result);
        }

        [TestMethod]
        public void AddManyNumbersReturnsSum()
        {
            var result = _calc.Add("1,2,3,4,5");

            Assert.AreEqual("15", result);
        }

        [TestMethod]
        public void AddNewlineDelimitedNumbersReturnsSum()
        {
            var result = _calc.Add("1\n2,3");

            Assert.AreEqual("6", result);
        }

        [TestMethod]
        public void AddCustomDelimitedNumbersReturnsSum()
        {
            var result = _calc.Add("//;\n1;2");

            Assert.AreEqual("3", result);
        }

        [TestMethod]
        public void AddNegativeNumbersThrows()
        {
            Action act = () => _calc.Add("1,-2,-3");

            var ex = Assert.ThrowsException<Exception>(act);
            Assert.AreEqual("Negatives not allowed: -2, -3", ex.Message);
        }
    }
}
