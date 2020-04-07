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
           

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            

            //Print the first number of the array
                      

            //Print the last number of the array            
            

            //Use this method to print out your numbers from arrays or lists
            

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */
            

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers


            //Sort the array in order now            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            

            //Print the capacity of the list to the console
            

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            

            //Print the new capacity
            

            //Create a method that prints if a user number is present in the list

            
            //Print all numbers in the list
            

            //Create a method that will remove all odd numbers from the list then print results
            

            //Sort the list then print results
            

            //Convert the list to an array and store that into a variable
            

            //Clear the list
            
                        
            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            throw new NotImplementedException();
        }

        private static void OddKiller(List<int> numberList)
        {
            throw new NotImplementedException();
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            throw new NotImplementedException();
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            throw new NotImplementedException();
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            throw new NotImplementedException();
        }       

        private static void ReverseArray(int[] array)
        {
            throw new NotImplementedException();
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
