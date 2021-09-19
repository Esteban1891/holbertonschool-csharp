using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[][] jagged = new int[3][]
            {
                new int[] {0, 1, 2, 3},
                new int[] {0, 1, 2, 3, 4, 5, 6},
                new int[] {0, 1}
            };

            for (i = 0 ; i < 3 ; i++)
            {
                for (j = 0 ; j < jagged[i].Length ; j++)
                {
                    Console.Write(jagged[i][j]);
                    if (j < jagged[i].Length - 1)
                        Console.Write(" ");
                }
                Console.Write('\n');
            }
        }
    }
}
