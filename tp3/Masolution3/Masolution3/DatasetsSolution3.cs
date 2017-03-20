using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Masolution3
{
    class DatasetsSolution3
    {
        public static object ConfigurationManager { get; private set; }

        public static void Main(string  [] args)
        {
            string connectionString = GetConnectionString();
            ConnectToData(connectionString);
        }

        private static void ConnectToData(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Table", "Resultat");
                connection.Open();
                Console.WriteLine("The SqlConnection is open.");

                SqlCommand command = new SqlCommand("SELECT * FROM dbo.Personne", connection);
                command.CommandType = CommandType.Text;

                adapter.SelectCommand = command;

                DataSet dataSet = new DataSet("Resultat");
                adapter.Fill(dataSet);

                connection.Close();
                Console.WriteLine("The SqlConnection is closed.");
            }
        }

        private static string GetConnectionString()
        {
            return "Data Source=(local);Initial Catalog=Northwind;"
                + "Integrated Security=SSPI";
        }
    }
}
