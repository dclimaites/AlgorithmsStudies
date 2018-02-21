using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudies
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] storage = {1, 3, 4, 8, 20, 50, 77, 100 };
            int number = -500;
            SearchAlgorithms.BinarySearch searchRoutine = new SearchAlgorithms.BinarySearch();
            System.Console.WriteLine($"The index of the search numer {number} is {searchRoutine.Find(number, storage)}");
            System.Console.ReadKey();
        }
    }
}
