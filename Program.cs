using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> animalNames = new List<string>
            { "fawn", "gibbon", "heron", "ibex", "jackalope"};

            IEnumerable<string> longAnimalNames =
                animalNames.Where(name => name.Contains("o"));

            foreach (var i in longAnimalNames)
            {
                Console.WriteLine(i);
                
            }
            Console.Read();
        }
    }
}
