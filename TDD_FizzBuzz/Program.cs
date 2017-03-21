using FizzBuzz.Library;
using System;

namespace TDD_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(
                    FizzBuzzer.GetValue(i));
                
            }
            Console.ReadKey();
        }
    }
}
