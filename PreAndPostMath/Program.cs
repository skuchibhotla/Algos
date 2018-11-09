using System;

namespace PreAndPostMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5 - 3 = " + (5 - 3));
            Console.WriteLine("5 * 3 = " + (5 * 3));
            Console.WriteLine("5 / 3 = " + (5 / 3));
            Console.WriteLine("5.2 % 3 = " + (5.2 % 3));

            int i = 0;
            Console.WriteLine("i++=" + (i++));
            Console.WriteLine("++i=" + (++i));
            Console.WriteLine("i--=" + (i--));
            Console.WriteLine("--i=" + (--i));

            Console.WriteLine("i += 3 = " + (i += 3));
            Console.WriteLine("i -= 2 = " + (i -= 2));
            Console.WriteLine("i *= 2 = " + (i *= 2));
            Console.WriteLine("i /= 2 = " + (i /= 2));
            Console.WriteLine("i %= 2 = " + (i %= 2));

            int a = 2;
            int b = 3;

            Console.WriteLine("Before: ");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Console.WriteLine("After: ");
            Console.WriteLine("a+++b-- = " + (a++ + b--));
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
