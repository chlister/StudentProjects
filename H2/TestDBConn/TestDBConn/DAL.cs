using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using KroellOgCamrIRummet.Models;
//using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace KroellOgCamrIRummet
{
    public class DAL
    {
        private MySqlConnection myConn;
        private static DAL instance;
        string cs = @"server=10.108.233.8;port=3306;userid=david;pwd=Dj110489;database=StarSystemDB";
        public static DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL();
                }
                return instance;
            }
        }
        private MySqlConnection MyConn
        {
            get { return myConn; }
            set
            {
                if (myConn == null)
                {
                    myConn = CreateConn();
                }
            }
        }
        private DAL()
        {
            MyConn = CreateConn();
        }
        //DbContext db = new DbContext();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <param name="arg"></param>
        /// <param name="delimiter"></param>
        private MySqlDataReader InitReader(string table, string delimiter)
        {
            string stmt = "SELECT * FROM "+table+" WHERE PName = '"+delimiter+"'";
            try
            {
                MyConn.Open();
                MySqlCommand cmd = MyConn.CreateCommand();
                cmd.CommandText = stmt;
                MySqlDataReader rdr = cmd.ExecuteReader();
                return rdr;
            }
            catch (Exception e)
            {
               throw e;
            }

        }
        public Planet GetPlanet(string name)
        {
            Planet p = new Planet();
            MySqlDataReader rdr = InitReader("Planets", name);
            try
            {
                while (rdr.Read())
                {
                    p.Day_Length = rdr["Day_Length"].ToString();
                    p.Name = rdr["PName"].ToString();
                    p.Num_Moons = Convert.ToInt16(rdr["Num_Moons"]);
                    p.Temperature_Day = Convert.ToDouble(rdr["Day_Temperature"]);
                    p.Temperature_Night = Convert.ToDouble(rdr["Night_Temperature"]);
                    p.Perimeter = Convert.ToSingle(rdr["Perimeter"]);
                    p.Year_Length = rdr["Year_Length"].ToString();
                }
                Debug.WriteLine(p.Name);
                return p;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (MyConn != null)
                {
                    MyConn.Close();
                }
            }
        }
        public Star GetStar()
        {
            Star s = new Star();
            MySqlDataReader rdr = InitReader("Star", "Sol");
            try
            {
                while (rdr.Read())
                {
                    s.Name = rdr["PName"].ToString();
                    s.Perimeter = Convert.ToSingle(rdr["perimeter"]);
                    s.Temperature = Convert.ToDouble(rdr["temperature"]);
                }
                return s;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (CreateConn() != null)
                {
                    CreateConn().Close();
                }
            }
        }
        private MySqlConnection CreateConn()
        {
            return new MySqlConnection(cs);
        }
    }
}
