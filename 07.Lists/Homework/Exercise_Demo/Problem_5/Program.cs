using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5
{
    class Program
    {
        static void Main()
        {
            var nums = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            var cmdArgs = Console.ReadLine().Split(' ');

            while (cmdArgs[0] != "print")
            {
                var command = cmdArgs[0];

                switch (command)
                {
                    case "add":
                        var insertIndex = int.Parse(cmdArgs[1]);
                        var insertElement = int.Parse(cmdArgs[2]);
                        nums.Insert(insertIndex, insertElement);
                        break;
                    case "addMany":
                        var insertRangeIndex = int.Parse(cmdArgs[1]);
                        var tempList = new List<int>();
                        for (int i = 2; i < cmdArgs.Length; i++)
                        {
                            tempList.Add(int.Parse(cmdArgs[i]));
                        }
                        
                        nums.InsertRange(insertRangeIndex, tempList);
                        break;
                    case "contains":
                        var containsElement = int.Parse(cmdArgs[1]);

                        if (nums.Contains(containsElement))
                        {
                            int index = nums.FindIndex(el => el == containsElement);

                            Console.WriteLine($"{index}");
                        }
                        else
                        {
                            Console.WriteLine("-1");
                        }
                        break;
                    case "remove":
                        var removeIndex = int.Parse(cmdArgs[1]);
                        nums.RemoveAt(removeIndex);
                        break;
                    case "shift":
                        var arr = new int[nums.Count];
                        var positions = int.Parse(cmdArgs[1]);

                        for (int i = 0; i < nums.Count; i++)
                        {
                            int index = i - positions;
                            if (index < 0)
                            {
                                while (index < 0)
                                {
                                    index = nums.Count - (index * -1);
                                }
                            }
                            arr[index] = nums[i];
                        }

                        nums = arr.ToList();
                        break;
                    case "sumPairs":
                        var tempSumList = new List<int>();

                        if (nums.Count%2 == 0)
                        {
                            for (int i = 0; i < nums.Count; i+=2)
                            {
                                tempSumList.Add(nums[i] + nums[i+1]);
                            }

                            nums = tempSumList;
                        }
                        else
                        {
                            for (int i = 0; i < nums.Count - 1; i+=2)
                            {
                                tempSumList.Add(nums[i] + nums[i+1]);
                            }
                            tempSumList.Add(nums[nums.Count - 1]);
                            nums = tempSumList;
                        }

                        break;

                }

                cmdArgs = Console.ReadLine().Split(' ');
            }

            Console.WriteLine("[" + string.Join(", ", nums) + "]");
        }
    }
}
