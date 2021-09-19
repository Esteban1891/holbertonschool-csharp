using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            for (num = 0 ; num <= 99 ; num++)
            {
                if (num < 99)
                    Console.Write($"{num:00}, ");
                else if (num == 99)
                {
                    Console.WriteLine($"{num:00}");
                }
            }
        }
    }
}
