using System.IO;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"..\..\..\Resources\02. Line Numbers\Input.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = $"{i + 1}. {lines[i]}";
            }

            File.WriteAllLines(@"../../Output.txt", lines);
        }
    }
}
