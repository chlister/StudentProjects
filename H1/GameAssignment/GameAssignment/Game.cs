using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAssignment
{
    class Game
    {
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }



        public string Genre { get; private set; }
        private string Publisher { get; set; }
        private DateTime Date { get; set; }
        private string Name { get; set; }
        private bool GameStart { get; set; }

        public Game()
        {
            Publisher = "No Publisher";
        }
        public Game(string genre, string publisher)
        {
            Publisher = publisher;
            Genre = genre;
        }
        public bool Start()
        {
            bool GameStart = true;
            return GameStart;
        }
        public bool End()
        {
            bool GameStart = false;
            return GameStart;
        }
        public string LoadGame()
        {
            string load = "Game loaded";
            return load;
        }
        public void LoadAssets()
        {
            Console.WriteLine("Assets loaded");
        }
        public string GetPublisher()
        {
            return Publisher;
        }

    }
}
