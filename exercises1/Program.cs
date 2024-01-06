using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Exercise 1");

        int userValue;

        do
        {
            Console.WriteLine("Please enter any number: ");
            string userInput = Console.ReadLine();

            if (IsInteger(userInput, out userValue))
            {
                Console.WriteLine($"Okay, you entered a number: {userValue}");
                break; // Exit the loop as a valid number is entered.
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (true); // Continue the loop until the user enters a valid number.
    }

    // IsInteger method attempts to convert the given string to an integer.
    // If successful, it returns true and passes the result through the out parameter.
    // If unsuccessful, it returns false and assigns a default value to the out parameter.
    static bool IsInteger(string input, out int result)
    {
        result = 0; // A default value can be assigned.

        return int.TryParse(input, out result);
    }
}
