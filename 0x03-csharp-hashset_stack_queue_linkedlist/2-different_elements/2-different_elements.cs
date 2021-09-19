using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        var new_list = new List<int>();
        int i, j, same;
        var list1_lengh = list1.Count;
        var list2_lengh = list2.Count;

        for (i = 0 ; i < list1_lengh ; i++)
        {
            same = 0;
            for (j = 0 ; j < list2_lengh ; j++)
            {
                if (list1[i] == list2[j])
                {
                    same = 1;
                    break;
                }
            }
            if (same == 0)
                new_list.Add(list1[i]);
        }
        for (i = 0 ; i < list2_lengh ; i++)
        {
            same = 0;
            for (j = 0 ; j < list1_lengh ; j++)
            {
                if (list2[i] == list1[j])
                {
                    same = 1;
                    break;
                }
            }
            if (same == 0)
                new_list.Add(list2[i]);
        }
        new_list.Sort();
        return(new_list);
    }
}
