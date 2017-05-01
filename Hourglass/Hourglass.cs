using System;

namespace Hourglass
{
    class Hourglass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', 2 * n + 1));
            Console.WriteLine(".*" + new string(' ', 2 * n - 3) + ("*."));
            for (int i = 2; i < n; i++)
            {
                Console.WriteLine(new string('.', i) + "*" + new string('@', 2 * (n - i) - 1) + "*" + new string('.', i));
            }
            Console.WriteLine(new string('.', n) + "*" + new string('.', n));
            for (int i = n - 1; i >= 2; i--)
            {
                Console.WriteLine(new string('.', i) + "*" + new string(' ', n - i - 1) + "@" + new string(' ', n - i - 1) + "*" + new string('.', i));
            }
            Console.WriteLine(".*" + new string('@', 2 * n - 3) + ("*."));
            Console.WriteLine(new string('*', 2 * n + 1));
        }
    }
}