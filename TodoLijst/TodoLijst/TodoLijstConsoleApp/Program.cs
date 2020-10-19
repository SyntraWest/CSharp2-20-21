using System;
using System.Threading;
using TodoLijstLibrary;
using TodoItemExtensions;

namespace TodoLijstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var todoItem = new TodoItem
            {
                Naam = "iets doen",
                TegenWanneer = DateTime.Now.AddDays(1)
            };

            Thread.Sleep(TimeSpan.FromSeconds(5));

            todoItem.WerkNuAf();

            var tijdAfgewerkt = todoItem.HoeLangAfgewerkt();

            Console.WriteLine(tijdAfgewerkt);
        }
    }
}
