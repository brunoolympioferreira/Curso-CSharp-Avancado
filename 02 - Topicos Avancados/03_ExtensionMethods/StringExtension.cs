﻿namespace _03_ExtensionMethods;
public static class StringExtension
{
    public static string FirstToUpper(this String str)
    {
        string primeira = str.Substring(0,1);

        string segunda = str.Substring(1);

        return primeira.ToUpper() + segunda;
    }
}
