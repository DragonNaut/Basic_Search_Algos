using System;

namespace Basic_Search_Algos
{
    class Program
    {
        static void Main(string[] args)
        {

            Random randomNumber = new Random();
            

            int[] intArray = new int[100];
            

           for(int i = 0; i < intArray.Length; i ++) // Can not use foreach to assign data to elements in a collection
            {
                intArray[i] = randomNumber.Next(1, 100);
            }

            foreach (int i in intArray)
                Console.WriteLine($"{i}");
        }
    }
}
