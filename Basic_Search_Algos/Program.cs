using System;

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

            

           for(int i = 0; i < intArray.Length; i ++) // Can not use foreach to assign data to elements in a collection
            {
                intArray[i] = randomNumber.Next(1, 100);
            }

            //foreach (int i in intArray)
            //{
            //    Console.WriteLine($"{i}");
            //}

            Console.Write("Enter a number to search: ");
            searchNumber = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Search Number: {searchNumber}");

            found = BoolSeqSearch(intArray, searchNumber);

            if (found)
            {
                Console.WriteLine($"{searchNumber} is in the array.");
            }
            else
            {
                Console.WriteLine($"{searchNumber} is not in the array.");
            }

            foundAtIndex = SeqSearchIndexReturn(intArray, searchNumber);

            if (foundAtIndex >= 0)
            {
                Console.WriteLine($"{searchNumber} found in the array at position {foundAtIndex}.");
            }
            else
            {
                Console.WriteLine($"{searchNumber} is not found in the array.");
            }
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

        static int SeqSearchIndexReturn(int[] arr, int sValue) // Returns the index of the element of the search value
        {
            
            for (int index = 0; index < arr.Length-1; index++ )
            {
                if (arr[index] == sValue)
                    return index;
            }
            return -1;
        }
    }
}
