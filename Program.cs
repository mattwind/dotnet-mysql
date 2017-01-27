using System;
using MySql.Data.MySqlClient;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string MySqlServerIP = "172.17.0.2";
            string MySqlDbName   = "test";
            string MySqlUserName = "root";
            string MySqlPassword = "mypassword";

            MySqlConnection dbConn = new MySqlConnection("server=" + MySqlServerIP + ";database=" + MySqlDbName + ";uid=" + MySqlUserName + ";password=" + MySqlPassword);
            MySqlCommand cmd = dbConn.CreateCommand();

            cmd.CommandText = "show databases";

            try
            {
                dbConn.Open();
            }
            catch (Exception)
            {
                Console.WriteLine("Error connecting to MySQL server.");
            }

            finally
            {
                if (dbConn.State != 0)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine(reader["Database"]);
                    }
                    dbConn.Close();
                }
            }
        }
    }
}
