using System;

/// <summary>
/// This is our class Zombie.
/// </summary>
class Obj
{
    /// <summary>
    /// This is our class Zombie.
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return(true);
        else
            return(false);
    }
}
