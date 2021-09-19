using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int i;

        if (size == 0)
        {
            Console.Write('\n');
        }
        else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        int[] new_array = new int[size];
        for (i = 0 ; i < new_array.Length ; i++)
        {
            new_array[i] = i;
            if (i < new_array.Length - 1)
                Console.Write(new_array[i] + " ");
            else
                Console.WriteLine(new_array[i]);
        }
        return(new_array);
    }
}
