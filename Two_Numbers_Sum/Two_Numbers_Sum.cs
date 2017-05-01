using System;

namespace Two_Numbers_Sum
{
    class Two_Numbers_Sum
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;
            int count1 = 0;
            for (int i = begin; i >= end; i--)
            {
                for (int j = begin; j >= end; j--)
                {
                    if (j + i >= magicNumber)
                    {
                        count++;
                        if (j + i == magicNumber)
                        {
                            Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNumber})");
                            return;
                        }
                    }
                    if (i + j != magicNumber) count1++;
                }
            }
            if (count1 > 0) Console.WriteLine($"{count1} combinations - neither equals {magicNumber}");
        }
    }
}