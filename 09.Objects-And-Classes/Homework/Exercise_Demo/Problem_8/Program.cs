using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var input = Console.ReadLine();

            while (input != "end of dates")
            {
                var mentorArgs = input.Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

                Student student;
                var mentorName = mentorArgs[0];
                if (students.Any(m => m.Name == mentorName))
                {
                    student = students.FirstOrDefault(m => m.Name == mentorName);
                }
                else
                {
                    student = new Student();
                    student.Name = mentorName;
                    student.AttendanceDates = new List<DateTime>();
                    student.Comments = new List<string>();
                }
                
                
                for (int i = 1; i < mentorArgs.Length; i++)
                {
                    var attDate = mentorArgs[i];

                    var parsedDate = DateTime.ParseExact(attDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    student.AttendanceDates.Add(parsedDate);
                }

                students.Add(student);

                input = Console.ReadLine();
            }

            var secInput = Console.ReadLine();

            while (secInput != "end of comments")
            {
                var mentorArgs = secInput.Split('-');

                var mentorName = mentorArgs[0];

                if (students.Any(m => m.Name == mentorName))
                {
                    var mentor = students.FirstOrDefault(m => m.Name == mentorName);
                    
                    mentor.Comments.Add(mentorArgs[1]);
                }

                secInput = Console.ReadLine();
            }

            foreach (var student in students.OrderBy(m => m.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");

                foreach (var comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");

                foreach (var attendDate in student.AttendanceDates.OrderBy(d => d))
                {
                    Console.WriteLine($"-- {attendDate:dd/MM/yyyy}");
                }
            }
        }
    }

    public class Student
    {
        public List<string> Comments { get; set; }

        public string Name { get; set; }

        public List<DateTime> AttendanceDates { get; set; }
    }
}
