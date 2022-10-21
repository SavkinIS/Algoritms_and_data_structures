using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Algoritms.SEARCH_AND_SORTING_ALGORITHMS.Find
{
    internal class SimpleSearch
    {
        private static int[] ints = new int[]
            {
               0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
            };

        #region SEARCHING IN AN UNORDERED ARRAY
        public static void SearchingInUnorderedArray(int f)
        {
            int[] arr = new int[]
            {
                9,0, 1, 7, 2, 3,8, 4, 5, 6
            };

            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == f)
                {
                    index = i;
                    break;
                }
            }

            Console.WriteLine(index);
        }
        #endregion

        #region SEARCHING IN AN ORDERED ARRAY
        public static void BinarySearch(int f)
        {
            int index = -1;

            int left = ints.GetLowerBound(0);
            int right = ints.GetUpperBound(0);

            if (left == right)
                index = left;

            while (true)
            {
                if (right - left == 1)
                {
                    if (ints[left] == f)
                    {
                        index = left;
                        break;
                    }
                    if (ints[right] == f)
                    {
                        index = right;
                        break;
                    }
                }
                else
                {
                    int middle = left + (right - left) / 2;
                    int comparer = ints[middle].CompareTo(f);
                    if (comparer == 0)
                    {
                        index = middle;
                        break;
                    }
                    else if (comparer < 0)
                        left = middle;
                    else if (comparer > 0)
                        right = middle;
                }
            }

            Console.WriteLine(index);
        } 
        public static void BinarySearchRecursion(int f)
        {
            int index = -1;

            int left = ints.GetLowerBound(0);
            int right = ints.GetUpperBound(0);


            index = FindWithRecursion(ints, left, right, f);
            Console.WriteLine(index);
        }

        private static int FindWithRecursion<T>(T[] arr, int firstElement, int lastElement, T elementToSearch) where T : IComparable, IEquatable<T>
        {
            if (firstElement == lastElement)
                return firstElement;

            while (true)
            {
                if (lastElement - firstElement == 1)
                {
                    if (arr[firstElement].Equals(elementToSearch))
                    {
                        return firstElement;
                    }
                    if (arr[lastElement].Equals(elementToSearch))
                    {
                        return lastElement;
                    }
                }
                else
                {
                    int middle = firstElement + (lastElement - firstElement) / 2;
                    int comparer = arr[middle].CompareTo(elementToSearch);
                    if (comparer == 0)
                    {
                        return middle;
                    }
                    else if (comparer < 0)
                        return FindWithRecursion<T>(arr, middle, lastElement, elementToSearch);
                    else if (comparer > 0)
                        return FindWithRecursion<T>(arr, firstElement, middle, elementToSearch);

                    return -1;
                }
            }
            
        }

        public static void JumpSearch(int f)
        {
            int arrLength = ints.Length;
            int jumpStep = (int) MathF.Sqrt(ints.Length);
            int previouseStep = 0;
            int index = -1;

            while (ints[Math.Min(jumpStep, arrLength)] - 1 < f)
            {
                previouseStep = jumpStep;

                jumpStep += (int)MathF.Sqrt(ints.Length);
                if (previouseStep >= arrLength)
                    break;
            }

            while (ints[previouseStep] < f)
            {
                previouseStep++;
                if (previouseStep == Math.Min(jumpStep, arrLength))
                    break;
            }

            if (ints[previouseStep] == f)
                index = previouseStep;

            Console.WriteLine(index);
        }
        #endregion
    }
}
