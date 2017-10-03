using System;
using System.Numerics;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigint = new BigInteger();

            int centuries = int.Parse(Console.ReadLine());

            int years = centuries*100;
            int days = (int)(years*365.2422);
            uint hours = (uint)days*24;
            ulong minutes = hours*60;
            ulong seconds = minutes*60;
            ulong miliseconds = seconds*1000;
            BigInteger microseconds = miliseconds*1000;
            BigInteger nanoseconds = microseconds*1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
