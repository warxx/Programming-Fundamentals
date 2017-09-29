using System;

namespace Problem_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());


            bool isFound = false;
            int magicFirstNum = 0;
            int magicSecondNum  = 0;

            int combinationCounter = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if (i + j == magicNum)
                    {
                        magicFirstNum = i;
                        magicSecondNum = j;
                        isFound = true;
                    }

                    combinationCounter++; 
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNum}");
            }
            else
            {
                Console.WriteLine($"Number found! {magicFirstNum} + {magicSecondNum} = {magicNum}");                
            }
        }
    }
}
