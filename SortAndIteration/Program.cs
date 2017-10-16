using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace SortAndIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSortTwoItemTypesArrayWithHelper();

            TestSortTwoItemTypesArrayNoHelper();

            TestSortThreeItemTypesArray();
        }

        private static void TestSortTwoItemTypesArrayWithHelper()
        {
            var unsortedArray = new[] { 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b' };

            var arraySorter = new CollectionSorter();

            System.Console.WriteLine("Before Sort:");
            PrintCollection(unsortedArray);

            var sortedArray = arraySorter.SortTwoItemTypesArrayWithHelper<char>(unsortedArray, 'a');

            System.Console.WriteLine("After Sort:");
            PrintCollection(sortedArray);
        }

        private static void TestSortTwoItemTypesArrayNoHelper()
        {
            var unsortedArray = new[] { 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b' };

            var arraySorter = new CollectionSorter();

            System.Console.WriteLine("Before Sort:");
            PrintCollection(unsortedArray);

            var sortedArray = arraySorter.SortTwoItemTypesArrayNoHelper<char>(unsortedArray, 'a');

            System.Console.WriteLine("After Sort:");
            PrintCollection(sortedArray);
        }
        private static void TestSortThreeItemTypesArray()
        {
            var unsortedArray = new[] { 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b' };

            var arraySorter = new CollectionSorter();

            unsortedArray = new[] { 'a', 'c', 'b', 'b', 'c', 'c', 'c', 'a', 'a', 'a', 'c', 'b', 'a', 'c', 'b', 'a', 'c', 'b', 'a', 'c' };

            System.Console.WriteLine("Before Sort:");
            PrintCollection(unsortedArray);

            var sortedArray = arraySorter.SortThreeItemTypesArray<char>(unsortedArray, 'b');

            System.Console.WriteLine("After Sort:");
            PrintCollection(sortedArray);
        }

        static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                if (item is null)
                {
                    Console.Write("null ");
                    continue;
                }
                Console.Write(item.ToString() + " ");
            }
            Console.Write('\n');
        }
    }
}
