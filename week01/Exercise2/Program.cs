using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string userGrade = Console.ReadLine();
        int gradePercentage = int.Parse(userGrade);

        string letter = "";
        string sign = "";

        if (gradePercentage >= 93)
        {
            letter = "A";
        }

        else if (gradePercentage == 92 || gradePercentage == 91 || gradePercentage == 90 )
        {
            letter = "A";
            sign = "-";
        }

        else if (gradePercentage == 83 || gradePercentage == 84 || gradePercentage == 85 || gradePercentage == 86)
        {
            letter = "B";
        }

        else if (gradePercentage == 82 || gradePercentage == 81 || gradePercentage == 80)
        {
            letter = "B";
            sign = "-";
        }

        else if (gradePercentage == 87 || gradePercentage == 88 || gradePercentage == 89)
        {
            letter = "B";
            sign = "+";
        }

        else if (gradePercentage == 73 || gradePercentage == 74 || gradePercentage == 75 || gradePercentage == 76)
        {
            letter = "C";
        }

        else if (gradePercentage == 72 || gradePercentage == 71 || gradePercentage == 70)
        {
            letter = "C";
            sign = "-";
        }

        else if (gradePercentage == 77 || gradePercentage == 78 || gradePercentage == 79)
        {
            letter = "C";
            sign = "+";
        }

        else if (gradePercentage == 63 || gradePercentage == 64 || gradePercentage == 65 || gradePercentage == 66)
        {
            letter = "D";
        }

        else if (gradePercentage == 62 || gradePercentage == 61 )
        {
            letter = "D";
            sign = "-";
        }

        else if (gradePercentage == 67 || gradePercentage == 68 || gradePercentage == 69)
        {
            letter = "D";
            sign = "+";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade for this course is: {letter}{sign}");

        if (gradePercentage >= 70)
        {
            Console.Write("Congratulations! You passed this course.");
        }

        else
        {
            Console.Write("You failed this course. Better luck next sem.");
        }
       
    }
}