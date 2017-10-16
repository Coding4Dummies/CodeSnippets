using System;
using System.Collections;
using System.Collections.Generic;


namespace SortAndIteration
{
    class CollectionSorter
    {
        public T[] SortTwoItemTypesArrayWithHelper<T>(T[] inputArray, T leftItem) where T : IComparable
        {
            var resultArray = new T[inputArray.Length];

            var leftIndex = 0;
            var rightIndex = resultArray.Length - 1;

            // Single iteration over the collection:
            foreach (T item in inputArray)
            {
                if (item.CompareTo(leftItem) == 1)
                {
                    resultArray[rightIndex] = item;
                    rightIndex--;
                    continue;
                }
                resultArray[leftIndex] = item;
                leftIndex++;
            }
            return resultArray;
        }

        public T[] SortTwoItemTypesArrayNoHelper<T>(T[] inputArray, T leftItem) where T : IComparable
        {
            var leftIndex = 0;
            var rightIndex = inputArray.Length - 1;

            while (leftIndex < rightIndex)
            {
                if (inputArray[leftIndex].CompareTo(leftItem) == 1)
                {
                    while (inputArray[rightIndex].CompareTo(leftItem) == 1)
                    {
                        rightIndex--;

                        if (leftIndex > rightIndex)
                            return inputArray;
                    }
                    SwapValues(leftIndex, rightIndex, inputArray);
                }
                leftIndex++;
            }
            return inputArray;
        }        

        public T[] SortThreeItemTypesArray<T>(T[] inputArray, T middleItem) where T : IComparable
        {
            var leftIndex = 0;
            var rightIndex = inputArray.Length - 1;
            var iterator = 0;

            while (iterator <= rightIndex)
            {
                if (inputArray[iterator].CompareTo(middleItem) < 0)
                {
                    SwapValues(iterator, leftIndex, inputArray);
                    leftIndex++;
                    iterator ++;
                    continue;
                }

                if (inputArray[iterator].CompareTo(middleItem) > 0)
                {
                    SwapValues(iterator, rightIndex, inputArray);
                    rightIndex--;
                    continue;
                }

                iterator ++;
            }

            return inputArray;
        }

        private void SwapValues<T>(int firstIndex, int secondIndex, T[] array)
        {
            T tempStorage = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = tempStorage;
        }
    }
}

