using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_practice
{
    partial class Program
    {
        static void Main(string[] args)
        {
  
        }

        static void usePrams()
        {
            var Calculator1 = new Calculator();

            Console.WriteLine(Calculator1.Add(1, 2, 3, 4, 5));

        }

        static void usePoints()
        {
            var point = new Point(20, 30);
            point.Move(new Point(50, 70));

            Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

            point.Move(100, 200);
            Console.WriteLine("Point has moved to ({0},{1})", point.X, point.Y);
        }
    }
}
