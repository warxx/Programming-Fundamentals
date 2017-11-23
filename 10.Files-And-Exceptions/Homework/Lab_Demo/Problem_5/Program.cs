using System;
using System.IO;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string asd = "asdasdasd";

            byte[] arr = System.Text.Encoding.ASCII.GetBytes(asd);

            foreach (var bye in arr)
            {
                Console.WriteLine(Convert.ToString(bye, 2).PadLeft(10, '0'));
                
            }

            var files = Directory.GetFiles(@"..\..\..\Resources\05. Folder Size\TestFolder");
            double sum = 0;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            Console.WriteLine($"{sum / 1024 / 1024}");

            sum = sum/1024/1024;

            File.WriteAllText(@"../../Output.txt", sum.ToString());
        }
    }
}
