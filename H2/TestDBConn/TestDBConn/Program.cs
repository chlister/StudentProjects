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
        static void Main(string[] args)
        {
            string cs = @"server=10.108.233.30;port=3306;userid=david;pwd=Dj110489;database=dummy";
            MySqlConnection conn = null;
            MySqlDataReader rdr = null;
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                string stmt = "SELECT * FROM DummyTable";
                MySqlCommand cmd = new MySqlCommand(stmt, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    Console.WriteLine(rdr.GetString(0));
                }

            }
            catch (MySqlException e)
            {
                Console.WriteLine($"Error: {e.ToString()}");
            }
            catch (Exception)
            {
                Console.WriteLine("Someething else");
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
            Console.ReadLine();
        }
    }
}
