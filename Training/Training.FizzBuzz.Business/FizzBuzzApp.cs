using System;

namespace Training.FizzBuzz.Business
{
    public class FizzBuzzApp
    {
        public FizzBuzzApp()
        {
        }

        public void Run()
        {
            var num = 0;

            do
            {
                Console.Write("Enter a number:");
                num = int.Parse(Console.ReadLine());

                Console.WriteLine(Check(num));
            } while (num != -1);
        }

        public string Check(int num)
        {
            var result = string.Empty;

            if(num % 3 == 0)
            {
                result += "Fizz";
            }

            if(num % 5 == 0)
            {
                result += "Buzz";
            }

            if(result.Length == 0)
            {
                result += num.ToString();
            }

            return result;
        }
    }
}