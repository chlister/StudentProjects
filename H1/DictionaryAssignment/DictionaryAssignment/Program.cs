using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Opgave 1 + 2
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Marc", 27);
            dict["Marc"] = 26;
            foreach (var person in dict)
            {
                Console.WriteLine("Name: {0}, Age: {1}", person.Key, person.Value);
            }
            #endregion
            #region Opgave 3
            Dictionary<string, bool> characters = new Dictionary<string, bool>()
            {
                {"Luke", true },
                {"Han", false },
                {"Chewbacca", false }
            };

            if (characters.Remove("Han"))
            {
                Console.WriteLine("Removed Han");
            }
            else
            {
                Console.WriteLine("Han not found");
            }
            #endregion
            #region Opgave 4
            Dictionary<string, bool> characters2 = new Dictionary<string, bool>()
            {
                {"Luke", true },
                {"Han", false },
                {"Chewbacca", false }
            };
            foreach (var person in characters2)
            {
                Console.WriteLine("Name: {0}, Jedi? {1}", person.Key, person.Value);
            }
            #endregion
            Console.ReadLine();
        }
    }
}
