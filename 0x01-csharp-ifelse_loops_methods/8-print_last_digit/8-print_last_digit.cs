using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        if (number < 0)
        {
            Console.Write((number % 10) * -1);
            return((number % 10) * -1);
        }
        else
        {
            Console.Write(number % 10);
            return(number % 10);
        }
    }
}
