using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class Program
    {
        public class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string VIN { get; set; }
        }
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { Make = "Marcedez", Model = "i50l", VIN = "A5", Year= 2010},
                new Car() { Make = "Ford", Model = "4Runner", VIN = "F6" , Year= 2013},
                new Car() { Make = "BMW", Model = "750li", VIN = "C3" , Year= 2015},
                new Car() { Make = "BMW", Model = "550li", VIN = "B2" , Year= 2018},
                new Car() { Make = "Audi", Model = "E50li", VIN = "D4", Year= 2020},
                new Car() { Make = "BMW", Model = "745li", VIN = "E5" , Year= 2021}
            };

            //Linq query

            /*var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2020
                       select car;
            */

            /* var orderCar = from car in myCars
                           orderby car.Year descending
                           select car;
            */

            //linq method
            //var bmws = myCars.Where(p => p.Make == "BMW");

            //var orderCar = myCars.OrderByDescending(p => p.Year);

            //var firstBMW = myCars.OrderByDescending(p=> p.Year).First(p => p.Make == "BMW");
            //Console.WriteLine(firstBMW.VIN);

            Console.WriteLine(myCars.TrueForAll(p=> p.Year > 2009));
           

            //foreach (var car in orderCar)
            //{
            //    Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
            //}
        }
    }
}
