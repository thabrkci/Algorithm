/* 
   Welcome to exercises 2
   This program takes a positive number from the user and checks whether it is a prime number.
*/

Console.WriteLine("Please enter a positive number:");
int value;

// Validate user input to ensure a positive integer is entered
while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
{
    Console.WriteLine("Invalid input. Please enter a positive number!");
    Console.Write("Please enter a positive number: ");
}

// Check if the entered number is prime using the IsAsal method
if (IsAsal(value))
{
    Console.WriteLine("The entered number is a prime number.");
}
else
{
    Console.WriteLine("The entered number is not a prime number.");
}

// Method to check if a number is prime
static bool IsAsal(int number)
{
    // If the number is less than 2, it is not prime
    if (number < 2)
        return false;

    // Iterate from 2 up to the square root of the number
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        // If the number is divisible evenly by i, it is not prime
        if (number % i == 0)
            return false;
    }

    // If no divisions resulted in an even division, the number is prime
    return true;
}
