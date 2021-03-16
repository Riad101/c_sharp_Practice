using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //var shape = new Shape(); //can not create object of any abstract class
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
