using System.IO;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var file1
                = File.ReadAllLines(@"..\..\..\Resources\04. Merge Files\FileOne.txt");

            var file2
                = File.ReadAllLines(@"..\..\..\Resources\04. Merge Files\FileTwo.txt");

            using (var output = File.CreateText(@"../../Output.txt"))
            {
                int lineNum = 0;

                while (lineNum < file1.Length || lineNum < file2.Length)
                {
                    if (lineNum < file1.Length)
                    {
                        output.WriteLine(file1[lineNum]);
                    }

                    if (lineNum < file2.Length)
                    {
                        output.WriteLine(file2[lineNum]);
                    }

                    lineNum++;
                }
            }
        }
    }
}
