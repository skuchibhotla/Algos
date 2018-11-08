using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the number to check if it is a Palindrome or not: ");
            int input = Convert.ToInt32(Console.ReadLine());

            string inputInString = input.ToString();
            int inputLength = inputInString.Length;

            int copyOfInput = input;

            int output = 0;
            for(int i = inputLength; i > 0; i--)
            {
                int digit = copyOfInput % 10;
                // output = output + (digit * (10 ^ (i-1)));

                double power = Convert.ToDouble(i - 1);
                // int tensMultiple = 10 ^ power;
                double tensMultiple = Math.Pow(10.0, power);
                double value = digit * tensMultiple;
                int valueInInt = Convert.ToInt32(value);
                output = output + valueInInt;

                copyOfInput = copyOfInput / 10;
            }

            Console.WriteLine("The reverse of " + input + " is: " + output);

            int difference = output - input;
            if(difference != 0)
            {
                Console.WriteLine("The value entered is not a palindrome. ");
            }
            else
            {
                Console.WriteLine("The value entered is a palindrome. ");
            }

            Console.ReadKey();
        }
    }
}
