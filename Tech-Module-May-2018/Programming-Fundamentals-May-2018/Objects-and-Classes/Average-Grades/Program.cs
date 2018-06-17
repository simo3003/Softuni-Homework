using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> studentGrades = new List<Student>();
            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                Student currentStudent = new Student
                {
                    Name = name,
                    Grades = input.Skip(1).Select(double.Parse).ToList()
                };
                if (currentStudent.AverageGrade >= 5.00)
                {
                    studentGrades.Add(currentStudent);
                }
            }

            foreach (var studentGrade in studentGrades.OrderBy(x=>x.Name).ThenByDescending(x=>x.AverageGrade))
            {
                Console.WriteLine($"{studentGrade.Name} -> {studentGrade.AverageGrade:f2}");
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade => Grades.Average();
    }
}

