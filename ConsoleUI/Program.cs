using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] firstNames = new string[] { "Joe", "John", "Doe" };

            for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine(firstNames[i]);
            }

            List<string> lastnames = new List<string>();
            lastnames.Add("Johanne");
            lastnames.Add("Brido");
            lastnames.Add("Donald");

            for (int i = 0; i < lastnames.Count; i++)
            {
                Console.WriteLine(lastnames[i]);
            }
            Console.ReadLine();
        }
    }
}
