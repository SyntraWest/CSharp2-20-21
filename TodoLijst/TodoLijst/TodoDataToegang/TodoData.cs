using System;
using System.Data.Common;
using TodoLijstLibrary;
using Dapper;

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
	                @eigenaar
	                ,@naam
	                )
            ";

            connection.Execute(sql, new
            {
                eigenaar = todoLijst.Eigenaar,
                naam = todoLijst.Naam
            });
        }

    }
}
