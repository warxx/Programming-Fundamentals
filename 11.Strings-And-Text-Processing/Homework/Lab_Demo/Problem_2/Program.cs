using System;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var str = Console.ReadLine().ToLower();

            int counter = 0;
            int index = text.IndexOf(str);

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(str, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
