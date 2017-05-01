using System;

namespace House_Painting
{
    class House_Painting
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double frontSide = x * x - 2 * 1.2;
            double backSide = x * x;
            double lateralSide = 2 * x * y - 2 * (1.5 * 1.5);
            double roofRedArea = 2 * x * y + 2 * (x * h / 2);
            double greenArea = frontSide + backSide + lateralSide;
            double ExpenseGreen = greenArea / 3.4;
            double ExpenseRed = roofRedArea / 4.3;
            Console.WriteLine($"{ExpenseGreen:f2}");
            Console.WriteLine($"{ExpenseRed:f2}");
        }
    }
}