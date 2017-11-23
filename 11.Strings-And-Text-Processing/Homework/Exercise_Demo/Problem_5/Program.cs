using System;
using System.Collections.Generic;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var charsDict = new Dictionary<char, char>();
            bool areExchangeable = true;

            var input = Console.ReadLine().Split(' ');

            var firstWord = input[0].ToLower();
            var secondWord = input[1].ToLower();

            if (firstWord.Length < secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    if (!charsDict.ContainsKey(firstWord[i]) && !charsDict.ContainsValue(secondWord[i]))
                    {
                        charsDict[firstWord[i]] = secondWord[i];
                    }
                    else
                    {
                        if (!charsDict.ContainsValue(secondWord[i]) || !charsDict.ContainsKey(firstWord[i]))
                        {
                            areExchangeable = false;
                            break;
                        }
                    }
                }

                if (areExchangeable)
                {
                    for (int i = firstWord.Length; i < secondWord.Length; i++)
                    {
                        if (!charsDict.ContainsValue(secondWord[i]))
                        {
                            areExchangeable = false;
                            break;
                        }
                    }
                }
            }
            else if (firstWord.Length > secondWord.Length)
            {
                for (int i = 0; i < secondWord.Length; i++)
                {
                    if (!charsDict.ContainsKey(secondWord[i]) && !charsDict.ContainsValue(firstWord[i]))
                    {
                        charsDict[secondWord[i]] = firstWord[i];
                    }
                    else
                    {
                        if (!charsDict.ContainsValue(firstWord[i]) || !charsDict.ContainsKey(secondWord[i]))
                        {
                            areExchangeable = false;
                            break;
                        }
                    }
                }

                if (areExchangeable)
                {
                    for (int i = secondWord.Length; i < firstWord.Length; i++)
                    {
                        if (!charsDict.ContainsValue(firstWord[i]))
                        {
                            areExchangeable = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    if (!charsDict.ContainsKey(firstWord[i]) && !charsDict.ContainsValue(secondWord[i]))
                    {
                        charsDict[firstWord[i]] = secondWord[i];
                    }
                    else
                    {
                        if (!charsDict.ContainsValue(secondWord[i]) || !charsDict.ContainsKey(firstWord[i]))
                        {
                            areExchangeable = false;
                            break;
                        }
                    }
                }
            }

            if (areExchangeable)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
