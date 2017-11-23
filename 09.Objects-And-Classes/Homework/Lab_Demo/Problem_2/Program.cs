using System;
using System.Linq;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();

            var rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int index = rnd.Next(words.Length);

                var word = words[i];
                words[i] = words[index];
                words[index] = word;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
