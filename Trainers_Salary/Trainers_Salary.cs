using System;

namespace Trainers_Salary
{
    class Trainers_Salary
    {
        static void Main(string[] args)
        {
            int count = 0;
            int countJelev = 0;
            int countRoYal = 0;
            int countRoli = 0;
            int countTrofon = 0;
            int countSino = 0;
            double numbersOfLections = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double averageBudget = budget / numbersOfLections;
            for (int i = 0; i < numbersOfLections; i++)
            {
                string name = Console.ReadLine();
                if (name == "Jelev") countJelev++;
                else if (name == "RoYaL") countRoYal++;
                else if (name == "Roli") countRoli++;
                else if (name == "Trofon") countTrofon++;
                else if (name == "Sino") countSino++;
                else count++;
            }
            Console.WriteLine($"Jelev salary: {countJelev * averageBudget:f2} lv");
            Console.WriteLine($"RoYaL salary: {countRoYal * averageBudget:f2} lv");
            Console.WriteLine($"Roli salary: {countRoli * averageBudget:f2} lv");
            Console.WriteLine($"Trofon salary: {countTrofon * averageBudget:f2} lv");
            Console.WriteLine($"Sino salary: {countSino * averageBudget:f2} lv");
            Console.WriteLine($"Others salary: {count * averageBudget:f2} lv");
        }
    }
}