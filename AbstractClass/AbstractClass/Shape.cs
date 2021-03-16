namespace AbstractClass
{
    partial class Program
    {
        public abstract class Shape
        {
            public int Height { get; set; }
            public int Width { get; set; }

            public abstract void Draw();

            public void copy()
            {
                System.Console.WriteLine("Copy shape into clipboard");
            } 
            
        }
    }
}
