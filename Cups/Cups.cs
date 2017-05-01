using System;

namespace Cups
{
    class Cups
    {
        static void Main(string[] args)
        {
            int numbersOfCups = int.Parse(Console.ReadLine());
            int working = int.Parse(Console.ReadLine());
            int workDay = int.Parse(Console.ReadLine());
            int hours = working * workDay * 8;
            double madeCups = Math.Truncate(hours / 5.0);
            if (madeCups < numbersOfCups) Console.WriteLine($"Losses: {(numbersOfCups - madeCups) * 4.2:f2}");
            else Console.WriteLine($"{(madeCups - numbersOfCups) * 4.2:f2} extra money");
        }
    }
}