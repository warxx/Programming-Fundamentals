using System;
using System.Numerics;

namespace Problem_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string opCode = Console.ReadLine();

            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');

                BigInteger result;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = (operandOne + 1);
                            Console.WriteLine(result);
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne-1;
                            Console.WriteLine(result);
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            Console.WriteLine(result);
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = (operandOne * operandTwo);
                            Console.WriteLine(result);
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
                
                opCode = Console.ReadLine();
            }
        }
    }
}
