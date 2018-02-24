using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDBConn
{
    class Program
    {
        // I am testing a connection to a remote MySQL server hosted on a linux machine
        static void Main(string[] args)
        {
            // Connection string for our local database
            string cs = @"server=10.108.233.30;port=3306;userid=david;pwd=Dj110489;database=dummy";
            MySqlConnection conn = null;
            MySqlDataReader rdr = null;
            try
            {
                conn = new MySqlConnection(cs);
                // Opening the connection
                conn.Open();
                string stmt = "SELECT * FROM DummyTable";
                // Testing if i have gotten the table and can select from it
                MySqlCommand cmd = new MySqlCommand(stmt, conn);
                // executing the select
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    // just need one piece of info to know that we're through
                    Console.WriteLine(rdr.GetString(0));
                }

            }
            catch (MySqlException e)
            {
                Console.WriteLine($"Error: {e.ToString()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Closing reader if it hasn't done so
                if (rdr != null)
                {
                    rdr.Close();
                }
                // Closing connection if it hasn't done so
                if (conn != null)
                {
                    conn.Close();
                }
            }
            Console.ReadLine();
        }
    }
}
