using System;

/// <summary>
/// This is our class Zombie.
/// </summary>
class Obj
{
    /// <summary>
    /// This is our class Zombie.
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
            return(true);
        else
            return(false);
    }
}
