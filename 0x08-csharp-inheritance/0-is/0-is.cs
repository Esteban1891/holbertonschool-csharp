using System;

/// <summary>
/// This is our class Zombie.
/// </summary>
class Obj
{
    /// <summary>
    /// This is our class Zombie.
    /// </summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
            return(true);
        else
            return(false);
    }
}
