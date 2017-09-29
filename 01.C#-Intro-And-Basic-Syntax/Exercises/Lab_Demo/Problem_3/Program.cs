using System;
using System.Text;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employeeId = int.Parse(Console.ReadLine());
            decimal monthlySalary = decimal.Parse(Console.ReadLine());

            var sb = new StringBuilder();
            sb
                .AppendLine($"Name: {name}")
                .AppendLine($"Age: {age}")
                .AppendLine($"Employee ID: {employeeId.ToString("D8")}")
                .AppendLine($"Salary: {monthlySalary:F2}");
            Console.WriteLine(sb);
        }
    }
}
