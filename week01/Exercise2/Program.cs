using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade (percentage): ");
        int grade = int.Parse(Console.ReadLine());
        string letterGrade = "";
        bool passGrade = true;
        if (grade < 60)
        {
            letterGrade = "F";
            passGrade = false;
        } else
        {
            if (grade < 70)
            {
                letterGrade = "D";
                passGrade = false;
            }
            else if (grade < 80)
            {
                letterGrade = "C";
            }
            else if (grade < 90)
            {
                letterGrade = "B";
            }
            else
            {
                letterGrade = "A";
            }
            int plusOrMinus = grade % 10;
            if (grade < 95)
            {
                if (plusOrMinus >= 7)
                {
                    letterGrade += '+';
                } 
                else if (plusOrMinus < 3)
                {
                    letterGrade += '-';
                }
            }
        }
        Console.WriteLine($"Your grade is a/an {letterGrade}.");
        if (passGrade)
        {
            Console.WriteLine("You pass the course!");
        }
        else
        {
            Console.WriteLine("Course Failed - but retakes are allowed!");
        }
    }
}