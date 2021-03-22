using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    partial class Program
    {
        static void Main(string[] args)
        {
             var car1 = new Car();
             car1.Make = "Oldsmobile";
             car1.Model = "Cutlas Supreme";
             car1.VIN = "A1";

             var car2 = new Car();
             car2.Make = "Geo";
             car2.Model = "Prism";
             car2.VIN = "B2";

             var book1 = new Book();
             book1.Title = "C# advanced practices";
             book1.Author = "John Smith";
             book1.ISBN = "JS1234";

             List<Car> carList = new List<Car>();

             carList.Add(car1);
             carList.Add(car2);

             foreach (var car in carList)
             {
                 Console.WriteLine(car.Model);
             }

             List<Book> bookList = new List<Book>();
             bookList.Add(book1);

             Dictionary<string, Car> carDictionary = new Dictionary<string, Car>();

             carDictionary.Add(car1.VIN, car1);
             carDictionary.Add(car2.VIN, car2);

             Console.WriteLine(carDictionary["B2"].Make);
            

            //Console.ReadLine();

            //object initializer/ No need of constructor

            //var car1 = new Car() { Make = "BMW", Model = "750li", VIN = "C3" };
            //var car2 = new Car() { Make = "Audi", Model = "E50li", VIN = "D4" };

            //Collection Initializer

            //List<Car> myCarList = new List<Car>() { 
            //    new Car { Make = "Marcedez", Model = "i50l", VIN = "E5"},
            //    new Car { Make = "Ford", Model = "4Runner", VIN = "F6"}
            //};

        }
    }
}
