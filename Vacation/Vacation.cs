using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seson = Console.ReadLine();
            string place = "";
            string location = "";
            double price = 0;
            if (budget <= 1000)
            {
                place = "Camp";
                if (seson == "Summer")
                {
                    location = "Alaska";
                    price = 0.65 * budget;
                }
                if (seson == "Winter")
                {
                    location = "Morocco";
                    price = 0.45 * budget;
                }
            }
            if (budget > 1000 && budget <= 3000)
            {
                place = "Hut";
                if (seson == "Summer")
                {
                    location = "Alaska";
                    price = 0.80 * budget;
                }
                if (seson == "Winter")
                {
                    location = "Morocco";
                    price = 0.60 * budget;
                }
            }
            if (budget > 3000)
            {
                place = "Hotel";
                if (seson == "Summer")
                {
                    location = "Alaska";
                    price = 0.90 * budget;
                }
                if (seson == "Winter")
                {
                    location = "Morocco";
                    price = 0.90 * budget;
                }
            }
            Console.WriteLine($"{location} - {place} - {price:f2}");
        }
    }
}