using System;
using System.Linq;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(' ').Select(e => char.Parse(e)).ToArray();
            var arr2 = Console.ReadLine().Split(' ').Select(e => char.Parse(e)).ToArray();

            int n = 0;

            if (arr1.Length < arr2.Length)
            {
                n = arr1.Length;
            }
            else
            {
                n = arr2.Length;
            }

            char[] biggerArr = null;
            char[] smallerArr = null;
            bool areEqual = true;

            for (int i = 0; i < n; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    biggerArr = arr1;
                    smallerArr = arr2;
                    areEqual = false;
                    break;
                }

                if (arr1[i] < arr2[i])
                {
                    biggerArr = arr2;
                    smallerArr = arr1;
                    areEqual = false;
                    break;
                }
            }


            if (areEqual && arr1.Length != arr2.Length)
            {
                if (arr1.Length > arr2.Length)
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                }
                else if (arr1.Length < arr2.Length)
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                }
            }
            else if (areEqual && arr1.Length == arr2.Length)
            {
                Console.WriteLine(string.Join("", arr1));
                Console.WriteLine(string.Join("", arr2));
            }
            else
            {
                Console.WriteLine(string.Join("", smallerArr));
                Console.WriteLine(string.Join("", biggerArr));
            }
        }
    }
}
