using System;
using MySql.Data.MySqlClient;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MySqlConnection dbConn = new MySqlConnection("server=172.17.0.2;database=test;uid=root;password=mypassword");
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "show databases";
            
            try
            {                    
                dbConn.Open();                             
            } catch (Exception)
            {                                                
                Console.WriteLine("Error connecting to database.");                 
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
