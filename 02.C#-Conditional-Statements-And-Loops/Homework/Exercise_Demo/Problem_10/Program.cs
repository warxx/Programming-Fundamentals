using System;
using System.Text;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                var arr = new int[i];

                for (int j = 0; j < i; j++)
                {
                    arr[j] = i;
                }
                sb.AppendLine(string.Join(" ", arr));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
