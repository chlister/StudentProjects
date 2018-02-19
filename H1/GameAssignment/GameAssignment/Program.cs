using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            List<Game> games = new List<Game>();
            for (int i = 0; i < 10; i++)
            {
                games.Add(new Game());
            }
            games.Add(new Game("Horror", "Beasty Games"));
            foreach (var item in games)
            {

                Console.WriteLine(item.GetPublisher());
                Console.WriteLine("Item number: {0}",num);
                Console.WriteLine(item.Start());
                Console.WriteLine(item.LoadGame());
                item.LoadAssets();
                Console.WriteLine(item.End());
                num++;
            }
            /**
            Game game1 = new Game();
            Game game2 = new Game();
            Game game3 = new Game();
            Game game4 = new Game();
            Game game5 = new Game();
            Game game6 = new Game();
            Game game7 = new Game();
            Game game8 = new Game();
            Game game9 = new Game();
            Game game10 = new Game();
            */
            Console.ReadLine();
        }
    }
}
