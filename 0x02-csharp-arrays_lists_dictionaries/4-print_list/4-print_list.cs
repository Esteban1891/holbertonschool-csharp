using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        int i;
        List<int> new_list = new List<int>();
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        for (i = 0 ; i <= size - 1 ; i++)
        {
            new_list.Add(i);
            if (i < size -1)
                Console.Write($"{new_list[i]} ");
            else
                Console.Write(new_list[i]);
        }
        Console.Write('\n');
        return(new_list);
    }
}
