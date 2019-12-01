using System;
using System.Collections.Generic;
using System.Linq;

namespace example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random _rand = new Random(1024);

            //Generate list of random int variables
            var unsorted = Enumerable.Range(0, 10)
                                    .Select(r => _rand.Next(100))
                                    .ToList();
            List<int> sorted;


            Console.WriteLine("Original array elements:");
            foreach (var item in unsorted)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var algorithm = new MergeSort();
            sorted = algorithm.Sort(unsorted);

            Console.WriteLine("Sorted array elements: ");
            foreach (var item in sorted)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }        
    }
}