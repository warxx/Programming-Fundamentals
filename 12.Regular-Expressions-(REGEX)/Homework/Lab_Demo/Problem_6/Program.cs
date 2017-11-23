using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb =  new StringBuilder();

            var input = Console.ReadLine();

            var regex = new Regex(@"<a.*?href.*?=(.*)>(.*?)<\/a>");
            string replacement = "[URL href=$1]$2[/URL]";


            while (input != "end")
            {
                input = regex.Replace(input, replacement);

                sb.AppendLine(input);

                input = Console.ReadLine();
            }

            Console.WriteLine(sb);
        }
    }
}
