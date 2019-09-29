using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Parse_Tags
{
    public class Program
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();
            var opendedTag = "<upcase>";
            var closeTag = "</upcase>";

            int startIndex = inputText.IndexOf(opendedTag);
            while (startIndex != -1)
            {
                var endIndex = inputText.IndexOf(closeTag);
                if (endIndex == -1)
                {
                    break;                 
                }
                var toBeReplaced = inputText.Substring(startIndex, endIndex + closeTag.Length - startIndex);

                var replaced = toBeReplaced.Replace(opendedTag, String.Empty).Replace(closeTag, String.Empty).ToUpper();

                inputText = inputText.Replace(toBeReplaced, replaced);


                startIndex = inputText.IndexOf(opendedTag);
                
            }
            Console.WriteLine(inputText);
        }
    }
}
