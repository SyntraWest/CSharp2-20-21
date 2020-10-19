using System;
using System.Runtime.CompilerServices;
using TodoLijstLibrary;

namespace TodoItemExtensions
{
    /// <summary>
    /// Naam van de klasse speelt geen rol
    /// Het is niet altijd nodig om een nieuw project te maken voor extension methods
    /// De namespace hoeft niet te verschillen van het type waarvoor je extension methods gebruikt
    /// </summary>
    public static class Extensions
    {
        public static TimeSpan? HoeLangAfgewerkt(this TodoItem todoItem)
        {
            // voorbeeld TimeSpan
            //DateTime a = DateTime.Now;
            //DateTime b = DateTime.UtcNow;
            //TimeSpan utcVerschil = a - b;

            return DateTime.Now - todoItem?.WanneerKlaar;
        }
    }
}
