using System;
using System.Collections;

namespace Basic_Search_Algos
{
    class Program
    {
        static void Main(string[] args)
        {

            Random randomNumber = new Random();
            
            int[] intArray = new int[100];

            int searchNumber;
            bool found;
            int foundAtIndex;

            ArrayList intArrayList = new ArrayList();

            for (int i = 0; i < 100; i++)
                intArrayList.Add(randomNumber.Next(1, 100)); 

            intArrayList.Sort();


             Console.Write("Enter a number to search: ");
             searchNumber = Convert.ToInt32(Console.ReadLine());
             foundAtIndex = ArrayListBinarySearch(intArrayList, searchNumber);

            if (foundAtIndex >= 0)
            {
                Console.WriteLine($"{searchNumber} found in the Array List at position {foundAtIndex}.");
            }
            else
            {
                Console.WriteLine($"{searchNumber} is not found in the Array List.");
            }


            //for(int i = 0; i < intArray.Length; i ++) // Can not use foreach to assign data to elements in a collection
            // {
            //     intArray[i] = randomNumber.Next(1, 100);
            // }


            // Console.Write("Enter a number to search: ");
            // searchNumber = Convert.ToInt32(Console.ReadLine());



            // found = BoolSeqSearch(intArray, searchNumber);

            // if (found)
            // {
            //     Console.WriteLine($"{searchNumber} is in the array.");
            // }
            // else
            // {
            //     Console.WriteLine($"{searchNumber} is not in the array.");
            // }

            // foundAtIndex = SeqSearchIndexReturn(intArray, searchNumber);

            // if (foundAtIndex >= 0)
            // {
            //     Console.WriteLine($"{searchNumber} found in the array at position {foundAtIndex}.");
            // }
            // else
            // {
            //     Console.WriteLine($"{searchNumber} is not found in the array.");
            // }


        }

        static bool BoolSeqSearch(int[] arr, int sValue) // Basic Sequential Search
        {
            for (int index = 0; index < arr.Length-1; index++)
            {
                if (arr[index] == sValue)
                    return true;
                
            }

            return false;
        }

        static int SeqSearchIndexReturn(int[] arr, int sValue) // If found, Returns the index of the element of the search value, else returns -1
        {
            
            for (int index = 0; index < arr.Length-1; index++ )
            {
                if (arr[index] == sValue)
                    return index;
            }
            return -1;
        }

        static int FindMin(int[] arr) // return the minimum value
        {
            int min = arr[0];

            for (int index = 0; index < arr.Length-1; index++)
            {
                if (arr[index] < min)
                    min = arr[index];
            }
            return min;

        }

        static int FindMax(int[] arr) // find the maximum value
        {
            int max = arr[0];

            for (int index = 0; index > arr.Length - 1; index++)
            {
                if (arr[index] > max)
                    max = arr[index];
            }

            return max;
        }

        static int ArrayBinarySearch(int[] arr, int sValue) // Binary Search, returns index of the number, else returns -1
        {
            int upperBound = arr.Length - 1;
            int lowerBound = 0;
            int mid;

            while(lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;

                if (arr[mid] == sValue)
                {
                    return mid;
                }
                else
                {
                    if (sValue < arr[mid])
                        upperBound = (mid - 1);
                    else
                    {
                        lowerBound = (mid + 1);
                    }
                }
                
                
            }

            return -1;
        }

        static int ArrayListBinarySearch(ArrayList arr, int sValue) // Binary Search, returns index of the number, else returns -1
        {
            int upperBound = arr.Count;
            int lowerBound = 0;
            int mid;

            while (lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;

                if ( (Int32.Parse(arr[mid].ToString()) == sValue) )
                {
                    return mid;
                }
                else
                {
                    if (sValue < (Int32.Parse(arr[mid].ToString() )) )
                        upperBound = (mid - 1);
                    else
                    {
                        lowerBound = (mid + 1);
                    }
                }


            }

            return -1;
        }

    }
}
