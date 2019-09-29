using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.User_Logs
{
    public class Program
    {
        public static void Main()
        {
            var result = new SortedDictionary<string,Dictionary<string,int>>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }
                var tokens = inputLine.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var ipFull = tokens[0].Split('=');
                var messageFull = tokens[1].Split('=');
                var userFull = tokens[2].Split('=');

                var currentIp = ipFull[1];
                var currentMessage = messageFull[1];
                var currentUser = userFull[1];

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

            

            foreach (var user in result)
            {
                var outputResult = new StringBuilder();
                Console.WriteLine($"{user.Key}: ");
                foreach (var ipAndMsg in user.Value)
                {
                    outputResult.Append($"{ipAndMsg.Key} => {ipAndMsg.Value}, ");
                }
                var resultAsString = outputResult.ToString().TrimEnd(new []{',',' '});
                Console.WriteLine(resultAsString + '.');
            }

            
        }
    }
}
