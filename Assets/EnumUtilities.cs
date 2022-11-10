using System;

public class EnumUtilities
{
    public static bool CompareEnums<T>(T firstEnum, T secondEnum) where T : IConvertible
    {
        int commobBitmask = Convert.ToInt32(firstEnum) & Convert.ToInt32(secondEnum);

        foreach(T currentEnum in Enum.GetValues(typeof(T)))
        {
            if((commobBitmask & Convert.ToInt32(currentEnum)) != 0)
            {
                return true;
            }
        }

        return false;
    }
}
