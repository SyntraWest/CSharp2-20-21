using System;

namespace ExtensionLibrary
{
    public static class StringExtension
    {
        public static string BWordtCC(this string oorspronkelijk)
        {
            return oorspronkelijk.Replace("b", "cc");
        }
    }
}
