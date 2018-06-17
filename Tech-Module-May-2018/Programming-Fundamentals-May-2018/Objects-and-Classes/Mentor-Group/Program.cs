using System;
using System.Collections.Generic;
using System.Linq;

namespace Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Student> report = new SortedDictionary<string, Student>();
            string joinedInput = Console.ReadLine();
            List<string> input = joinedInput.Split(' ', ',').ToList();
            while (joinedInput != "end of dates")
            {
                Student student = new Student();
                List<DateTime> attendanceDates = new List<DateTime>();
                string name = input[0];
                if (input.Count > 1) // check if there are any dates after the name
                {
                    //attendanceDates.AddRange(input.Skip(1).Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", null))); haven't tested, could be faster / slower than the for loop
                    for (int i = 1; i < input.Count; i++) // adds all of the dates to a temp list
                    {
                        DateTime currentDate = DateTime.ParseExact(input[i], "dd/MM/yyyy", null);
                        attendanceDates.Add(currentDate);
                    }
                }
                student.AttendanceDates.AddRange(attendanceDates);
                if (report.ContainsKey(name))
                {
                    report[name].AttendanceDates.AddRange(attendanceDates);
                }
                else
                {
                    report.Add(name, student);
                }
                joinedInput = Console.ReadLine();
                input = joinedInput.Split(' ', ',').ToList();
            }
            joinedInput = Console.ReadLine();
            input = joinedInput.Split('-').ToList();
            while (joinedInput != "end of comments")
            {
                string name = input[0];
                if (report.ContainsKey(name))
                {
                    report[name].Comments.Add(input[1]);
                }
                joinedInput = Console.ReadLine();
                input = joinedInput.Split('-').ToList();
            }

            foreach (var student in report)
            {
                Console.WriteLine($"{student.Key}");
                Console.WriteLine("Comments:");
                foreach (var comment in student.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var attendedDate in student.Value.AttendanceDates.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {attendedDate:dd/MM/yyyy}");
                }
            }
        }
    }

    class Student
    {
        public List<string> Comments { get; set; }
        public List<DateTime> AttendanceDates { get; set; }

        public Student()
        {
            AttendanceDates = new List<DateTime>();
            Comments = new List<string>();
        }
    }
}
