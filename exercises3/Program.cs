using System;

namespace Exercises3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Exercises 3");
            Console.WriteLine("///Please Enter the Number to Determine the Array Length:");
            int arrayLength;

            // Validate user input to ensure a positive integer is entered for the array length
            while (!int.TryParse(Console.ReadLine(), out arrayLength) || arrayLength <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a valid positive number for the array length.");
                Console.Write("Please enter the number to determine the array length: ");
            }

            // Get user input for each element of the array
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Please enter the {i + 1}. number:");

                // Validate user input to ensure a positive integer is entered for each array element
                while (!int.TryParse(Console.ReadLine(), out int userInput) || userInput <= 0)
                {
                    Console.WriteLine("Invalid input! Please enter a valid positive number.");
                    Console.Write($"Please enter the {i + 1}. number: ");
                }

                // Process the user input as needed (e.g., store in an array)
                // int[] numbers = new int[arrayLength];
                // numbers[i] = userInput;
            }
        }
    }
}
