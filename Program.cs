using System;

class Program
{
    static void Main()
    {
        // Step 1: Prompt the user to enter the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Arrays to store students' names and grades
        string[] studentNames = new string[numberOfStudents];
        double[] studentGrades = new double[numberOfStudents];

        // Step 2: Collect each student's name and grade using a loop
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.Write($"Enter the name of student {i + 1}: ");
            studentNames[i] = Console.ReadLine();

            Console.Write($"Enter the grade of {studentNames[i]}: ");
            studentGrades[i] = double.Parse(Console.ReadLine());
        }

        // Step 3: Calculate the average grade
        double totalGrades = 0;
        for (int i = 0; i < numberOfStudents; i++)
        {
            totalGrades += studentGrades[i];
        }
        double averageGrade = totalGrades / numberOfStudents;

        // Step 4: Print each student's name, grade, and pass/fail status
        Console.WriteLine("\nStudent Grades:");
        for (int i = 0; i < numberOfStudents; i++)
        {
            string status = studentGrades[i] >= 50 ? "Passed" : "Failed";
            Console.WriteLine($"Name: {studentNames[i]}, Grade: {studentGrades[i]}, Status: {status}");
        }

        // Step 5: Print the average grade of the class
        Console.WriteLine($"\nThe average grade of the class is: {averageGrade}");
    }
}

