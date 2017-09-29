using System;
using System.Collections.Generic;

namespace Problem_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (Math.Abs(a - b) < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = a; j <= b; j++)
                    {
                        for (int k = a; k <= b; k++)
                        {
                            for (int l = a; l <= b; l++)
                            {
                                for (int m = a; m <= b; m++)
                                {
                                    if (j <= i || k <= j || l <= k || m <= l)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        list.Add($"{i} {j} {k} {l} {m}");
                                    }
                                }
                            }
                        }
                    }
                }

                foreach (var str in list)
                {
                    Console.WriteLine(str);
                }   
            }
            
        }
    }
}
