using System.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPatter
{
    public class DatabaseConnection
    {
        private static DatabaseConnection dbcon;
        private SqlConnection con;
        private string connectionString = "Data Source={server};Initial Catalog={database};User ID={username};Password={password};";

        private DatabaseConnection()
        {
            con = new SqlConnection(connectionString);
        }

        public static DatabaseConnection GetDBConnection()
        {
            if (dbcon == null)
            {
                dbcon = new DatabaseConnection();
            }
            return dbcon;
        }

        public async void OpenCn()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    await con.OpenAsync();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Open cn error: " + ex.Message);
            }
        }

        public async void CloseCn()
        {
            try
            {
                if (con.State != ConnectionState.Closed)
                {
                    await con.CloseAsync();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Close cn error: " + ex.Message);
            }
        }

        public SqlDataReader ExecuteQuery(string query)
        {
            using (SqlCommand command = new SqlCommand(query, con))
            {
                SqlDataReader reader = null;
                try
                {
                    reader = command.ExecuteReader();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error reader: " + ex.Message);
                }
                
                return reader;
            }
        }

    }
}