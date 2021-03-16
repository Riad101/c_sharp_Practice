using System;

namespace Inheritance_practice
{
    partial class Program
    {
        public class PresentationObject
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public void copy()
            {
                Console.WriteLine("Object copied to clipboared");
            }

            public void duplicate()
            {
                Console.WriteLine("Object was duplicated");
            }
        }
    }
}
