using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            string tempString = "A collection of random words.";
            Console.WriteLine("Is empty or Null? " + String.IsNullOrEmpty(tempString));
            Console.WriteLine("Is empty or has White Space?" + String.IsNullOrWhiteSpace(tempString));

            Console.WriteLine("Index of 'bunch': " + tempString.IndexOf("bunch"));
            Console.WriteLine("Index of 'collection': " + tempString.IndexOf("collection"));

            Console.WriteLine("2nd word is (2 to end): " + tempString.Substring(2));
            Console.WriteLine("2nd word is (2 to 6): " + tempString.Substring(2, 6));
        }
    }
}
