using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Character_Multiplier
{
    public class Program
    {
        public static void Main()
        {
            var texts = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder firstText = new StringBuilder(texts[0]);
            StringBuilder secondText = new StringBuilder(texts[1]);
            Multiply(firstText, secondText);

        }

        private static void Multiply(StringBuilder firstText, StringBuilder secondText)
        {

            var result = 0;

            var endLoop = Math.Min(firstText.Length, secondText.Length);
            for (int i = 0; i < endLoop; i++)
            {
                result += (int)firstText[i] * (int)secondText[i];
                firstText[i] = (char) 0;
                secondText[i] = (char) 0;
            }

            foreach (var symbol in firstText.ToString())
            {
                result += (char) symbol;
            }
            foreach (var symbol in secondText.ToString())
            {
                result += (char) symbol;
            }
            Console.WriteLine(result);
        }
    }
}
