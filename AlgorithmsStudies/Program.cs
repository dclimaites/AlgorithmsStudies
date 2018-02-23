using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsStudies.SearchAlgorithms;

namespace AlgorithmsStudies
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] storage = {1, 3, 4, 8, 20, 50, 77, 100 };
            int number = -500;
            BinarySearch searchRoutine = new BinarySearch();
            Console.WriteLine($"The index of the search numer {number} is {searchRoutine.Find(number, storage)}");
            Console.ReadKey();
        }
    }
}
