using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        int i;
        LinkedList<int> list = new LinkedList<int>();

        if (size < 0)
            return(list);

        for (i = 0 ; i < size ; i++)
        {
            Console.WriteLine(i);
            list.AddLast(i);
        }
        return(list);
    }
}
