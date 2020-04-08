using System;
using Training.FizzBuzz.Business;
using Training.StringCalculator.Business;
using static System.Console;

namespace Training.App.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Select which program to run:");
            WriteLine("1) FizzBuzz");
            WriteLine("2) String Calculator");
            var selection = int.Parse(ReadLine());

            switch(selection)
            {
                case 1:
                    new FizzBuzzApp().Run();
                    break;
                case 2:
                    new StringCalculatorApp().Run();
                    break;
                default:
                    return;
            }
        }
    }
}
