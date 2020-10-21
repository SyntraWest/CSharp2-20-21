using System;
using System.Data.Common;
using TodoLijstLibrary;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace TodoDataToegang
{

    /// <summary>
    /// Alle interacties die te maken hebben met de database
    /// voor TODO-items en TODO-lijsten gaan via deze klasse.
    /// </summary>
    public class TodoData
    {
        private readonly DbConnection connection;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection">Een open databaseverbinding</param>
        public TodoData(DbConnection connection)
        {
            this.connection = connection;
        }

        public void MaakTodoLijst(TodoLijst todoLijst)
        {
            const string sql = @"
                INSERT INTO TodoLijsten (
	                Eigenaar
	                ,Naam
	                )
                VALUES (
	                @Eigenaar
	                ,@Naam
	                )
            ";

            connection.Execute(sql, todoLijst);
        }

        public IEnumerable<TodoLijst> GeefTodoLijsten(string gebruiker)
        {
            string sql = @"
                SELECT LijstId
	                ,Naam
	                ,Eigenaar
                FROM TodoLijsten
                WHERE Eigenaar = @Eigenaar
                ";
            var reader = connection.Query<TodoLijst>(sql, new { Eigenaar = gebruiker });
            return reader.ToList();
        }
    }
}
