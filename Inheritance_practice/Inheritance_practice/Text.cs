using System;

namespace Inheritance_practice
{
    partial class Program
    {
        public class Text : PresentationObject
        {
            public int FontSize { get; set; }
            public string FontName { get; set; }

            public void AddHyperLink(string url)
            {
                Console.WriteLine("we've added a link " +url);
            }
        }
    }
}
