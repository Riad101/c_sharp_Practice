using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ages = new List<int>();

            ages.Add(23);

            Console.WriteLine();
            Console.Write("Press enter to shutdown");
            Console.ReadLine();
        }
    }
}
