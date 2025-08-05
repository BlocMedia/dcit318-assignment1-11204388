using System;

public class MovieTicketCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Movie Ticket Price Calculator!");
        Console.WriteLine("---------------------------------------------");

        int age = 0;
        bool isValidInput = false;
        const decimal regularPrice = 10.00m; // GHC10 for regular tickets
        const decimal discountedPrice = 7.00m; // GHC7 for senior citizens and children

        // Loop until valid age input is received
        while (!isValidInput)
        {
            Console.Write("Please enter your age: ");
            string input = Console.ReadLine();

            // Try to parse the input as an integer
            if (int.TryParse(input, out age))
            {
                // Check if the age is a reasonable positive number
                if (age >= 0 && age <= 120) // Assuming a realistic age range
                {
                    isValidInput = true; // Input is valid, exit loop
                }
                else
                {
                    Console.WriteLine("Invalid age. Please enter a realistic age (e.g., between 0 and 120). Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a whole number for your age. Please try again.");
            }
        }

        decimal ticketPrice;

        // Determine the ticket price based on age
        if (age >= 65 || age <= 12)
        {
            ticketPrice = regularPrice-discountedPrice; // Senior citizen or child discount
            Console.WriteLine($"\nGreat news! Since you're {age} years old, you qualify for a discount!");
        }
        else
        {
            ticketPrice = regularPrice; // Regular price
        }

        Console.WriteLine($"Your ticket price is: GHC{ticketPrice:F2}"); // :F2 formats to 2 decimal places
        Console.WriteLine("\nEnjoy the movie! 🎬");
        Console.WriteLine("---------------------------------------------");
    }
}
