using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int counter = 0;
            for (i = 0 ; i <= 9 ; i++)
            {
                counter++;
                for (j = i + 0 ; j <= 9 ; j++)
                {
                    if (j < counter)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write($"{i}{j}");
                        if (i != 8 || j != 9)
                        {
                            Console.Write(", ");
                        }
                    }
                }
            }
            Console.Write("\n");
        }
    }
}
