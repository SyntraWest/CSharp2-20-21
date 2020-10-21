using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using TodoDataToegang;
using TodoLijstLibrary;

namespace TodoCrudConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = File.ReadAllText("connectionstring.txt");

            using (DbConnection connection = new SqlConnection(connectionString))
            {
                var data = new TodoData(connection);

                Console.WriteLine("Wat is je naam?");
                string gebruiker = Console.ReadLine();
                GebruikerToegang(data, gebruiker);
            }
        }

        private static void GebruikerToegang(TodoData data, string gebruiker)
        {
            string lijstnaam = "x";
            while (!string.IsNullOrWhiteSpace(lijstnaam))
            {
                PrintTodoLijsten(data, gebruiker);
                Console.WriteLine("Met welke lijst wil je werken? Geef de naam ervan");
                lijstnaam = Console.ReadLine();
                // 1 lijst ophalen...
                data.MaakTodoLijst(new TodoLijst
                {
                    Eigenaar = gebruiker,
                    Naam = lijstnaam
                });
            }
        }

        private static void PrintTodoLijsten(TodoData data, string gebruiker)
        {
            IEnumerable<TodoLijst> lijstenVoorGebruiker = data.GeefTodoLijsten(gebruiker);
            foreach (var lijst in lijstenVoorGebruiker)
            {
                Console.WriteLine($" - {lijst.Naam}");
            }
        }
    }
}
