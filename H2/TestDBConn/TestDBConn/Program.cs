using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KroellOgCamrIRummet;
using KroellOgCamrIRummet.Models;

namespace TestDBConn
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Planet p = DAL.Instance.GetPlanet("Jorden");
            Console.WriteLine(p.Name + " pER: " + p.Perimeter.ToString());
            Console.ReadLine();
        }
    }
}
