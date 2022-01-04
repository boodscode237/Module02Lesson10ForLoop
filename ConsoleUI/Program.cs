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

            List<string> fullNames = new List<string>();
            fullNames.Add("Johanne");
            fullNames.Add("Brido");
            fullNames.Add("Donald");
            fullNames.Add("Abel");

            foreach (var fullName in fullNames)
            {
                Console.WriteLine($"Hello {fullName}");
            }



            Dictionary<int, string> importantYears = new Dictionary<int, string>();
            importantYears.Add(1942, "Columbus arrives in central America");
            importantYears.Add(2018, "I arrived in Russia");
            importantYears.Add(2019, "CORONA VIRUS");
            importantYears.Add(2022, "Roulit");

            foreach (var importantYear in importantYears)
            {
                Console.WriteLine($"{importantYear.Key}: {importantYear.Value}");
            }
            Console.ReadLine();
        }
    }
}
