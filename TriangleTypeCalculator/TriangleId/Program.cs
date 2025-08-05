using System;

public class TriangleTypeCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Triangle Type Calculator!");
        Console.WriteLine("----------------------------------------");

        double side1 = 0.0;
        double side2 = 0.0;
        double side3 = 0.0;
        bool isValidInput = false;

        while (!isValidInput)
        {
            Console.Write("Please enter the length of the first side: ");
            string input1 = Console.ReadLine();

            Console.Write("Please enter the length of the second side: ");
            string input2 = Console.ReadLine();

            Console.Write("Please enter the length of the third side: ");
            string input3 = Console.ReadLine();

            if (double.TryParse(input1, out side1) && side1 > 0 &&
                double.TryParse(input2, out side2) && side2 > 0 &&
                double.TryParse(input3, out side3) && side3 > 0)
            {
                isValidInput = true; 
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter positive numerical values for all sides. Please try again.");
            }
        }

        Console.WriteLine("\n--- Calculating Triangle Type ---");

  
        if (side1 + side2 > side3 &&
            side1 + side3 > side2 &&
            side2 + side3 > side1)
        {
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine($"The triangle with sides {side1}, {side2}, and {side3} is an: Equilateral Triangle.");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine($"The triangle with sides {side1}, {side2}, and {side3} is an: Isosceles Triangle.");
            }
            else
            {
                Console.WriteLine($"The triangle with sides {side1}, {side2}, and {side3} is a: Scalene Triangle.");
            }
        }
        else
        {
            Console.WriteLine($"The lengths {side1}, {side2}, and {side3} cannot form a valid triangle.");
            Console.WriteLine("Remember: The sum of any two sides must be greater than the third side.");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey(); 
    }
}
