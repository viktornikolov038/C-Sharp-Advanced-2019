using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.User_Logs
{
    public class Program
    {
        public static void Main()
        {
            var result = new Dictionary<string,Dictionary<string,int>>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }

                var data = inputLine.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var currentUser = string.Join("",data[2].Skip(5));
                var currentIp = string.Join("", data[0].Skip(3));

                if (!result.ContainsKey(currentUser))
                {
                    result[currentUser] = new Dictionary<string, int>(); 
                }
                if (!result[currentUser].ContainsKey(currentIp))
                {
                    result[currentUser][currentIp] = 0;
                }

                result[currentUser][currentIp]++;
            }

            result = result.OrderBy(a => a.Key).ToDictionary(a => a.Key, a => a.Value);
            foreach (var username in result)
            {
                Console.WriteLine(username.Key + ":");
                var sb = new List<string>();
                foreach (var msg in username.Value)
                {
                    sb.Add($"{msg.Key} => {msg.Value}, ");
                }

                for (int i = 0; i < sb.Count; i++)
                {
                    var currentLine = sb[i];
                    if (i == sb.Count - 1)
                    {
                        currentLine = currentLine.Replace(",", ".");
                    }
                    Console.Write(currentLine);
                }
                Console.WriteLine();
                
            }
        }
    }
}
