using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:
            //Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well 
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            int[] arr = new int[50];
            Console.WriteLine("Array created, Press Enter to see the first and last number" +
                "of the array:");
            Console.ReadLine();
            //Create a method to populate the number array with 50 random numbers that are between 0 and 50h
            Populater(arr);

            //Print the first number of the array
            Console.WriteLine("");
            Console.WriteLine($"The first number of this array is: {arr[0]}");

            //Print the last number of the array            
            Console.WriteLine("");
            Console.WriteLine($"The last number of the array is: {arr[49]}. " +
                $"Press Enter to see array.");
            Console.ReadLine();
            //Use this method to print out your numbers from arrays or lists
            Console.WriteLine("");
            Console.WriteLine("The array is:");
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Press Enter to see array in reverse:");
            Console.ReadLine();

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */
            Console.WriteLine("");
            Console.WriteLine("Array in reverse is:");
            ReverseArray(arr);

            Console.WriteLine("Press Enter to see the Multiples of 3 in array");
            Console.ReadLine();

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("");
            Console.WriteLine("Multiples of 3:");

            ThreeKiller(arr);

            Console.Write("Press Enter to see the array in order:");
            Console.ReadLine();

            //Sort the array in order now
            Console.WriteLine("");
            Console.WriteLine("Array in Order:");
            OrderedArray(arr);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var numList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine("");
            Console.WriteLine("The Capacity is of this list is: " + numList.Capacity);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this
            Console.WriteLine("");
            Console.WriteLine("Your List is ready!");
            Populater(numList);

            //Print the new capacity
            Console.WriteLine("");
            Console.WriteLine("The new capacity of the new list is: " + numList.Capacity);

            //Create a method that prints if a user number is present in the list
            Console.WriteLine("");
            Console.WriteLine("Give me a number you'd like to see is in the list:");
            int userNum = int.Parse(Console.ReadLine());

            NumberChecker(numList, userNum);

            Console.WriteLine("Press Enter to see the list!");
            Console.ReadLine();

            //Print all numbers in the list
            Console.WriteLine("");
            foreach (int num in numList)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Press enter again to see the even numbers of the list: ");
            Console.ReadLine();

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("");
            OddKiller(numList);

            //Sort the list then print results
            Console.WriteLine("");
            Console.WriteLine("Press Enter to see the list in order:");
            Console.ReadLine();

            numList.Sort();
            foreach (int num in numList)
            {
                Console.WriteLine(num);
            }

            //Convert the list to an array and store that into a variable
            Console.WriteLine("");
            Console.WriteLine("Press Enter to convert list to an array: ");
            Console.ReadLine();

            int[] array = numList.ToArray();
            Console.WriteLine("Array created: " + array.Length);

            //Clear the list
            Console.WriteLine("");
            Console.WriteLine("Press Enter to clear list");
            Console.ReadLine();

            numList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            int a;
            for (int i = 1; i <= numbers.Length; i++)
            {
                a = i % 3;
                if (a == 0)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(i => i % 2 != 0);
            foreach(int num in numberList)
            {
                Console.WriteLine(num);
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine("Your number is on the list!");
            }
            else
            {
                Console.WriteLine("Your number is not on the list :(");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i <= 50; i++)
            {
                int j = rng.Next(51);
                numberList.Add(j);
            }
        }    

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(i);
            }
        }       

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
        }
        private static void OrderedArray(int[] array)
        {
            Array.Sort(array);
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
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
