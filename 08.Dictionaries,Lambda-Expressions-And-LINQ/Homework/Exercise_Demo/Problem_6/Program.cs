using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_6
{
    class Program
    {
        static void Main()
        {
            var userLogs = new Dictionary<string, Dictionary<string, List<string>>>();

            var input = Console.ReadLine().Split(' ');

            while (input[0] != "end")
            {
                var ipArgs = input[0].Split('=');
                var messageArgs = input[1].Split('=');
                var userArgs = input[2].Split('=');

                var ip = ipArgs[1];
                var message = messageArgs[1];
                var username = userArgs[1];

                if (!userLogs.ContainsKey(username))
                {
                    userLogs.Add(username, new Dictionary<string, List<string>>());
                    userLogs[username].Add(ip, new List<string>());
                    userLogs[username][ip].Add(message);
                }
                else
                {
                    if (!userLogs[username].ContainsKey(ip))
                    {
                        userLogs[username].Add(ip, new List<string>());
                    }

                    userLogs[username][ip].Add(message);
                }

                input = Console.ReadLine().Split(' ');
            }

            

            foreach (var user in userLogs.OrderBy(u => u.Key))
            {
                var result = $"{user.Key}: \n";

                foreach (var ip in user.Value)
                {
                    result += $"{ip.Key} => {ip.Value.Count}, ";
                }

                Console.WriteLine(result.Remove(result.Length - 2) + ".");
            }
        }
    }
}
