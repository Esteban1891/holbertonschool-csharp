using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        var new_list = new List<int>();
        int i, j;
        var list1_lengh = list1.Count;
        var list2_lengh = list2.Count;

        for (i = 0 ; i < list1_lengh ; i++)
        {
            for (j = 0 ; j < list2_lengh ; j++)
            {
                if (list1[i] == list2[j])
                    new_list.Add(list1[i]);
            }
        }
        return(new_list);
    }
}
