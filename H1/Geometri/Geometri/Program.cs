using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        { 
            Square sq = new Square(30.5);
            Square sq2 = new Square(30);
            Square sq3 = new Square(3.64);
            Square sq5 = new Square(80);
            Square sq4 = new Square(6.43);
            Console.WriteLine(sq.Perimeter());
            Console.WriteLine(sq2.Perimeter());
            Console.WriteLine(sq3.Perimeter());
            Console.WriteLine(sq4.Perimeter());
            Console.WriteLine(sq5.Perimeter());
            Console.WriteLine("Area");
            Console.WriteLine(sq.Area());
            Console.WriteLine(sq2.Area());
            Console.WriteLine(sq3.Area());
            Console.WriteLine(sq4.Area());
            Console.WriteLine(sq5.Area());
            Pause();
        }
        private static void Pause()
        {
            Console.ReadLine();
        }
    }
}
