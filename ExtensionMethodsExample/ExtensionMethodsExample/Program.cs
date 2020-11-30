using System;
using ExtensionLibrary;

namespace ExtensionMethodsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("alpha beta gamma".AWordtAbba());
            Console.WriteLine("alpha beta gamma".BWordtCC());
        }
    }

    internal static class StringExtensions
    {
        /// <summary>
        /// Mijn eerste extension method
        /// </summary>
        /// <param name="oorspronkelijk"></param>
        /// <returns></returns>
        internal static string AWordtAbba(this string oorspronkelijk)
        {
            return oorspronkelijk.Replace("a", "abba");
        }
    }
}
