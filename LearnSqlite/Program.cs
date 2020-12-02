using System;
using Microsoft.Data.Sqlite;

namespace LearnSqlite
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = "./myDb.db";

            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();
                var tableCmd = connection.CREATE;
                tableCmd.CommandText = "CREATE TABLE favourire_beers(name VARCHAR(50)) ";

            };



        }
    }
}
