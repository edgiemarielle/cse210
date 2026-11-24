using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Bea Marie Sanchez", "Integers");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Bea Marie Sanchez", "Integers", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Bea Marie Sanchez", "Integers", "Multiplication and Addition of Integers");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}