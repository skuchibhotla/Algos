using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // Declaring the first two elements of the sequence
            int first = 0;
            int second = 1;
            Console.WriteLine("Enter number of iterations you need: ");
            int iteration = Convert.ToInt32(Console.ReadLine());

            // Printing the first two elements of the Fibonacci Sequence
            Console.WriteLine("The Fibonacci Sequence is: ");
            Console.WriteLine(first);
            Console.WriteLine(second);

            int sum = 0;
            // Iteration
            for(int counter = 0; counter < iteration; counter++)
            {
                sum = first + second;
                Console.WriteLine(sum);

                first = second;
                second = sum;
            }

            Console.ReadKey();
        }
    }
}
