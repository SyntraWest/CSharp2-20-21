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
            tijdAfgewerkt = Extensions.HoeLangAfgewerkt(todoItem);

            Console.WriteLine(tijdAfgewerkt);

            //-----------------------------

            todoItem = null;

            // methode oproepen voor null:
            // todoItem.WerkNuAf(); // NullReferenceException

            // extension method oproepen voor null:
            tijdAfgewerkt = todoItem.HoeLangAfgewerkt(); // OK


        }
    }
}
