using System;
using System.Linq;

namespace Problem_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            bool isExist = false;

            for (int i = 0; i < nums.Length; i++)
            {
                var leftArr = nums.Take(i).ToArray();
                var rightArr = nums.Skip(i + 1).ToArray();

                if (leftArr.Sum() == rightArr.Sum())
                {
                    Console.WriteLine(i);
                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {
                Console.WriteLine("no");
            }
            //else if (!isExist && nums.Length == 1)
            //{
            //    Console.WriteLine(0);
            //}

        }
    }
}
