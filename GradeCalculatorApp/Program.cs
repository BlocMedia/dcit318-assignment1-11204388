using System;

public class GradeCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to NKG's Grade Calculator!");
        Console.WriteLine("--------------------------------");

        int grade = 0;
        bool isValidInput = false;
        string letterGrade;


        while (!isValidInput)
        {
            Console.Write("Please enter a numerical grade between 0 and 100: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out grade))
            {
                if (grade >= 0 && grade <= 100)
                {
                    isValidInput = true; 
                }
                else
                {
                    Console.WriteLine("Invalid input. The grade must be between 0 and 100. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a whole number. Please try again.");
            }
        }


        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"\nBased on the grade {grade}, the corresponding letter grade is: {letterGrade}");
    }
}
