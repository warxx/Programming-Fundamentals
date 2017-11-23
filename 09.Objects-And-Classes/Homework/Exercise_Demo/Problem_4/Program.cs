using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var student = new Student();

                var studentArgs = Console.ReadLine().Split(' ');

                var studentName = studentArgs[0];

                student.Name = studentName;

                for (int j = 1; j < studentArgs.Length; j++)
                {
                    var grade = double.Parse(studentArgs[j]);

                    student.Grades.Add(grade);
                }

                students.Add(student);
            }

            foreach (var student in students.Where(st => st.AverageGrade >= 5).OrderBy(st => st.Name).ThenByDescending(st => st.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }
        }
    }

    public class Student
    {
        public List<double> Grades = new List<double>();

        public string Name { get; set; }
        
        public double AverageGrade => Grades.Average();
    }
}
