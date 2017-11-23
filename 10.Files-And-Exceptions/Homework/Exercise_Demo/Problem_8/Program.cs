using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_8
{
    class Program
    {
        static void Main()
        {
            var students = new List<Student>();

            var input = File.ReadAllLines(@"../../Input.txt");
            File.Delete(@"../../Output.txt");

            for (int i = 1; i < input.Length; i++)
            {
                var studentArgs = input[i].Split(' ').ToArray();

                var name = studentArgs[0];
                var grades = new double[studentArgs.Length - 1];

                for (int j = 1; j < studentArgs.Length; j++)
                {
                    grades[j - 1] = double.Parse(studentArgs[j]);
                }

                var student = new Student
                {
                    Name = name,
                    Grades = grades
                };

                students.Add(student);
            }

            students.Where(e => e.AverageGrade >= 5)
                .OrderBy(st => st.Name)
                .ThenByDescending(st => st.AverageGrade)
                .ToList()
                .ForEach(st => File.AppendAllText(@"../../Output.txt", $"{st.Name} -> {st.AverageGrade:F2}" + Environment.NewLine));
        }
    }

    public class Student
    {
        public string Name { get; set; }

        public double[] Grades { get; set; }

        public double AverageGrade
        {
            get { return this.Grades.Average(); }
        }
    }
}
