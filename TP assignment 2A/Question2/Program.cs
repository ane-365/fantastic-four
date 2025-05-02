using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentScoresManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> scores = new List<int>();
            bool running = true;

            while(running)
            {
                Console.WriteLine("\nStudent Scores Management System");
                Console.WriteLine("1.Add Student Marks");
                Console.WriteLine("2.Display Marks(Ascending Order)");
                Console.WriteLine("3.Display Marks(Descending Order)");
                Console.WriteLine("4.Calculate and Display Average Grade");
                Console.WriteLine("5.Display Highest and Lowest Marks");
                Console.WriteLine("6.Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        AddMarks(scores);
                    break;
                    case 2:
                        DisplayMarksAscending(scores);
                    break;
                    case 3:
                        DisplayMarksDescending(scores);
                    break;
                     case 4:
                        CalculateAverageGrade(scores);
                    break;
                     case 5:
                        DisplayHighestAndLowest(scores);
                    break;
                    case 6:
                        running = false;
                    Console.WriteLine("Exiting…");
                    break;
                    default:
                    Console.WriteLine("Invalid choice.Please try again.");
                    break;
                }
            }
        }

        static void AddMarks(List<int> scores)
        {
            Console.Write("Enter the number of student marks to add: ");
            int numMarks = int.Parse(Console.ReadLine());

            for (int i = 0; i < numMarks; i++)
            {
                Console.Write($"Enter mark { i + 1}: ");
                int mark = int.Parse(Console.ReadLine());
                scores.Add(mark);
            }
             Console.WriteLine("Marks added successfully!");
        }

        static void DisplayMarksAscending(List<int> scores)
        {
            Console.WriteLine("\nMarks in Ascending Order:");
            var sortedScores = scores.OrderBy(mark => mark).ToList();
            sortedScores.ForEach(mark => Console.WriteLine(mark));
        }

        static void DisplayMarksDescending(List<int> scores)
{
    Console.WriteLine("\nMarks in Descending Order:");
    var sortedScores = scores.OrderByDescending(mark => mark).ToList();
    sortedScores.ForEach(mark => Console.WriteLine(mark));
}

        static void CalculateAverageGrade(List<int> scores)
        {
            if(scores.Count > 0)
            {
                Double average = scores.Average();
                Console.WriteLine($"\nAverage Grade: { average: F2}");
            }
            else
            {
                Console.WriteLine("\nNo marks available to calculate the average.");
            }
        }

        static void DisplayHighestAndLowest(List<int> scores)
        {
        if(scores.Count > 0)
            {
                    int highest = scores.Max();
                int lowest = scores.Min();
                Console.WriteLine($"\nHighest Mark: { highest}");
                Console.WriteLine($"Lowest Mark: { lowest}");
            }
        else
            {
            Console.WriteLine("\nNo marks available to determine highest and lowest.");
            }
        }
    }
}
