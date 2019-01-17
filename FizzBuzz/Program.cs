using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 1; index <= 100; index++)
            {
                if (index % 3 == 0 && index % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (index % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (index % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(index);
                }
            }
            Console.ReadKey();
        }
    }
}
