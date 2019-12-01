using System;
using System.Collections.Generic;
using System.Linq;

namespace example2
{
    class Program
    {
        public class Person : IComparable<Person>
        {
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public string Name { get; set; }
            public int Age { get; set; }

            public int CompareTo(Person other)
            {
                return Name.CompareTo(other.Name);
            }

            public override string ToString()
            {
                return $"Name: {Name}\tAge: {Age}";
            }
        }

        static void Main(string[] args)
        {
            var names = new List<string>()
            {
                "Tamra Grist"       ,
                "Bennie Sweatt"     ,
                "Misha Mattei"      ,
                "Mable Lampkins"    ,
                "Kaley Gervasi"     ,
                "Nettie Horace"     ,
                "Cassidy Broxton"   ,
                "January Berk"      ,
                "Michele Barga"     ,
                "Arden Emig"        ,
            };

            Random _rand = new Random(1024);

            //Generate list of random int variables
            var unsorted = Enumerable.Range(0, 10)
                                    .Select(r => new Person(names[r], _rand.Next(100)))
                                    .ToList();
            List<Person> sorted;


            Console.WriteLine("Original array elements:");
            foreach (var item in unsorted)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var algorithm = new MergeSort<Person>();
            sorted = algorithm.Sort(unsorted);

            Console.WriteLine("Sorted array elements: ");
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}