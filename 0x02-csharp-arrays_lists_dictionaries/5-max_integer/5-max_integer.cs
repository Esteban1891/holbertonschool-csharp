using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        int max_value;
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return(-1);
        }
        max_value = myList[0];
        foreach (var number in myList)
        {
            if (number > max_value)
                max_value = number;
        }
        return(max_value);
    }
}
