﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    public class Person
    {
        public string Name;
        public void introduce(String to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }    
        
        public static Person Parse (string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }   
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("John");
            person.introduce("smith");
            Console.ReadLine();
        }
    }
}
