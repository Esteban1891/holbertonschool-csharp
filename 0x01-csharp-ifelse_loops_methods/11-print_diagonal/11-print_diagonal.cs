using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        int repetitions, spaces;
        if (length <= 0)
            Console.Write("\n");
        else
        {
            for (repetitions = 0 ; repetitions < length ; repetitions++)
            {
                for (spaces = 0 ; spaces < repetitions ; spaces++)
                {
                    Console.Write(" ");
                }
                Console.Write("\\");
                if (repetitions != length - 1)
                    Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}
