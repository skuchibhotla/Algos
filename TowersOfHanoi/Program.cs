using System;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            char startPeg = 'A';    // Start Tower
            char endPeg = 'C';
            char tempPeg = 'B';
            // int totalDisks = 3;

            // Reading number of disks from Keyboard
            Console.Write("Enter the number of disks: ");
            int totalDisks = Convert.ToInt32(Console.ReadLine());

            SolveTowers(totalDisks, startPeg, endPeg, tempPeg);

            // Console.WriteLine("Hello World!");
        }

        private static void SolveTowers(int n, char startPeg, char endPeg, char tempPeg)
        {
            if(n > 0)
            {
                SolveTowers(n - 1, startPeg, tempPeg, endPeg);
                Console.WriteLine("Move disk from " + startPeg + " to " + endPeg);
                SolveTowers(n - 1, tempPeg, endPeg, startPeg);
            }
        }
    }
}
