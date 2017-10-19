using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = 
                {
                    "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday",
                    "Saturday",
                    "Sunday"
                };

            

            int dayNum = int.Parse(Console.ReadLine());

            switch (dayNum)
            {
                case 1:
                    Console.WriteLine(arr[dayNum - 1]);
                    break;
                case 2:
                    Console.WriteLine(arr[dayNum - 1]);
                    break;
                case 3:
                    Console.WriteLine(arr[dayNum - 1]);
                    break;
                case 4:
                    Console.WriteLine(arr[dayNum - 1]);
                    break;
                case 5:
                    Console.WriteLine(arr[dayNum - 1]);
                    break;
                case 6:
                    Console.WriteLine(arr[dayNum - 1]);
                    break;
                case 7:
                    Console.WriteLine(arr[dayNum - 1]);
                    break;
                default:
                    Console.WriteLine("Invalid Day!");
                    break;
            }
        }
    }
}
