using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "1111", Title = "c# advanced" };
            //List<int> ages = new List<int>();

            //ages.Add(23);

            //Console.WriteLine();
            //Console.Write("Press enter to shutdown");
            //Console.ReadLine();

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());


        }
    }
}
