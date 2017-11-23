using System;
using System.Text.RegularExpressions;

namespace Problem_9
{
    class Program
    {
        static void Main()
        {
            var str = Console.ReadLine();
            var pattern = Console.ReadLine();

            

            while (pattern.Length > 0)
            {
                int firstIndex = str.IndexOf(pattern);
                int lastIndex = str.LastIndexOf(pattern);

                if (firstIndex >= 0 && lastIndex >= 0 && firstIndex != lastIndex)
                {
                    str = str.Remove(lastIndex, pattern.Length);
                    str = str.Remove(firstIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    break;
                }

                var position = pattern.Length / 2;
                pattern = pattern.Remove(position, 1);
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(str);
        }
    }
}
