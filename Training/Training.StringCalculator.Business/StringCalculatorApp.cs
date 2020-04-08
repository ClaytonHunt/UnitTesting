using System;

namespace Training.StringCalculator.Business
{
    public class StringCalculatorApp
    {
        public StringCalculatorApp()
        {
        }

        public void Run()
        {
            var expression = "1 + 1";

            do
            {
                Console.Write("Enter an addition calculation:");
                expression = Console.ReadLine();

                Console.WriteLine(Add(expression));
            } while (!string.IsNullOrWhiteSpace(expression));
        }

        public string Add(string expression)
        {
            throw new Exception("You are going to have to write this code based on the tests");
        }
    }
}