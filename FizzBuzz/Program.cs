using System;

namespace FizzBuzz
{
    internal class Program
    {
        private static void Main()
        {
            for (var number = 1; number < 101; number++)
                Console.WriteLine(number.DisplayNumber());

            Console.ReadLine();
        }
    }
}