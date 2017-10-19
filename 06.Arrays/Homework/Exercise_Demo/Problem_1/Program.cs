using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split(' ');
            var secondArr = Console.ReadLine().Split(' ');

            if (firstArr[0] == secondArr[0])
            {
                int firstCounter = 0;
                int secondCounter = 0;

                while (firstArr[firstCounter] == secondArr[secondCounter])
                {
                    firstCounter++;
                    secondCounter++;

                    if (firstArr.Length <= firstCounter 
                        || secondArr.Length <= secondCounter)
                    {
                        break;
                    }
                }

                Console.WriteLine(firstCounter);
            }
            else if (firstArr[firstArr.Length - 1] == secondArr[secondArr.Length - 1])
            {
                int firstCounter = firstArr.Length - 1;
                int secondCounter = secondArr.Length - 1;
                int counter = 0;

                while (firstArr[firstCounter] == secondArr[secondCounter])
                {
                    firstCounter--;
                    secondCounter--;
                    counter++;

                    if (firstCounter < 0
                        || secondCounter < 0)
                    {
                        break;
                    }
                }

                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
