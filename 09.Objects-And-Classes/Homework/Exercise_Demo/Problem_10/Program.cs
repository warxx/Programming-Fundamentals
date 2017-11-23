using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Problem_10
{
    class Program
    {
        private string[] formats = new[] {"dd-MMM-yyyy", "d-MMM-yyyy"};

        static void Main(string[] args)
        {
            var towns = ReadTownsAndStudents();
            var groups = DistributeStudentsInGroup(towns);
            PrintGroups(groups);

            Console.WriteLine();
        }

        private static void PrintGroups(List<Group> groups)
        {
            Console.WriteLine($"Created {groups.Count} groups in {groups.GroupBy(g => g.Town).Count()} towns:");

            foreach (var group in groups)
            {
                Console.Write($"{group.Town.Name} => ");
                Console.WriteLine(string.Join(", ", group.Students.Select(st => st.Email)));
            }
        }

        private static List<Group> DistributeStudentsInGroup(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach (var town in towns.OrderBy(t => t.Name))
            {
                IEnumerable<Student> students = town.Students
                    .OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email);

                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }

            return groups;
        }

        private static List<Town> ReadTownsAndStudents()
        {
            var towns = new List<Town>();

            var input = Console.ReadLine();

            while (input != "End")
            {
                if (input.Contains("=>"))
                {
                    var townArgs = input.Split(new string[] {"=>"}, StringSplitOptions.RemoveEmptyEntries);

                    var townName = townArgs[0].Trim();
                    var seatsCountArgs = townArgs[1].Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
                    var seatsCount = int.Parse(seatsCountArgs[0].Trim());

                    var town = new Town()
                    {
                        Name = townName,
                        SeatsCount = seatsCount,
                        Students = new List<Student>()
                    };

                    towns.Add(town);
                }
                else
                {
                    var studentArgs = input.Split(new[] {' ', '|'}, StringSplitOptions.RemoveEmptyEntries);

                    var studentName = studentArgs[0] + " " + studentArgs[1];
                    var email = studentArgs[2];
                    var date = studentArgs[3];

                    var student = new Student()
                    {
                        Name = studentName,
                        Email = email,
                        RegistrationDate = DateTime.ParseExact(date, "d-MMM-yyyy", CultureInfo.InvariantCulture)
                    };

                    var town = towns.LastOrDefault();
                    town.Students.Add(student);
                }

                input = Console.ReadLine();
            }

            return towns;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    public class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }

    public class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
}
