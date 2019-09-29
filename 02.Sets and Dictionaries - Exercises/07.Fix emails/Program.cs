using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fix_emails
{
    public class Program
    {
        public static void Main()
        {
            var result = new Dictionary<string,string>();
            while (true)
            {
                var nameInput = Console.ReadLine();
                if (nameInput == "stop")
                {
                    break;
                }
                var currentEmail = Console.ReadLine();

                if (!result.ContainsKey(nameInput))
                {
                    result[nameInput] = String.Empty;
                }
                result[nameInput] = currentEmail;
            }

            foreach (var nameAndEmail in result)
            {
                var currentEmail = nameAndEmail.Value;

                if (currentEmail.Substring(currentEmail.Length - 2) == "us" ||
                    currentEmail.Substring(currentEmail.Length - 2) == "uk")
                {
                    result.Remove(currentEmail);
                }
                else
                {
                    Console.WriteLine($"{nameAndEmail.Key} -> {currentEmail}");
                }
            }
        }
    }
}
