using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Arrays
            // Create an integer Array of size 50

            var arr = new int [50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(arr);

            //Print the first number of the array

            Console.WriteLine($"{arr[0]} is the first number of the array.");

            //Print the last number of the array            

            Console.WriteLine($"{arr [arr.Length - 1]} is the first number of the array.");


            Console.WriteLine("All Numbers Original");

            //Use this method to print out your numbers from arrays or lists
            //NumberPrinter();

            NumberPrinter(arr);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(arr);

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            
            ThreeKiller(arr);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            
            Array.Sort(arr);
            NumberPrinter(arr);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");


            /*   Set Up   */
            //Create an integer List
            
            var NumLst = new List <int>();

            //Print the capacity of the list to the console
            
            Console.WriteLine($"{NumLst.Count}");

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            
            Populater(NumLst);

            //Print the new capacity
            
            Console.WriteLine($"New Capacity: {NumLst.Capacity}");

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!            

            int UserNum;
            bool isNum;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isNum = int.TryParse(Console.ReadLine(), out UserNum);
            
            } while(isNum = false);

            NumberChecker(NumLst, UserNum);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");

            //Print all numbers in the list
            NumberPrinter(NumLst);

            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            
            OddKiller(NumLst);

            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            NumLst.Sort();
            NumberPrinter(NumLst);
            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            
            var TheArray = NumLst.ToArray();

            //Clear the list
            
            NumLst.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
			{
                if(numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
			}
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i < -1 ; i--)
	        {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
	        }

            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Yes the required number is here!");
            }
            else
            {
                Console.WriteLine($"No, unfortunately the required number is not here");
            }
        }
        private static void Populater(List<int> numberList)
        {
            while (numberList.Count < 51)
            {
                Random rng = new Random();
                var num = rng.Next(0,50);
                numberList.Add(num);
            }
            
            NumberPrinter(numberList);

        }

        private static void Populater(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(0, 50);
            }
            

        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
