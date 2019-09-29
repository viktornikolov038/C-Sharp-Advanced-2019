using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Phonebook
{
    public class Program
    {
        public static void Main()
        {
            var result = new Dictionary<string,string>();
            while (true)
            {
                var inputContacts = Console.ReadLine().Split('-');
                if (inputContacts[0] == "search")
                {
                    break;
                }
                var currentContact = inputContacts[0];
                var currentNumber = inputContacts[1];
                if (!result.ContainsKey(currentContact))
                {
                    result[currentContact] = String.Empty;
                }
                result[currentContact] = currentNumber;
            }

            while (true)
            {
                var searchedContact = Console.ReadLine();
                if (searchedContact == "stop")
                {
                    break;
                }

                if (result.ContainsKey(searchedContact))
                {
                    Console.WriteLine($"{searchedContact} -> {result[searchedContact]}");
                }
                else
                {
                    Console.WriteLine($"Contact {searchedContact} does not exist.");
                }
            }
        }
    }
}
