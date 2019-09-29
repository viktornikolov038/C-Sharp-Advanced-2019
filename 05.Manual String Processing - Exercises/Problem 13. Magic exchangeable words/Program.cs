using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Magic_exchangeable_words
{
    public class Program
    {
        public static void Main()
        {
            var texts = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var firstTxt = texts[0];
            var secondTxt = texts[1];
            AreExchangeable(firstTxt, secondTxt);
        }

        private static void AreExchangeable(string firstTxt, string secondTxt)
        {
            var areExchang = true;
            var result = new Dictionary<char, char>();
            if (firstTxt.Length == secondTxt.Length)
            {
                for (int i = 0; i < firstTxt.Length; i++)
                {
                    var firstChar = firstTxt[i];
                    var secondChar = secondTxt[i];
                    if (!result.ContainsKey(firstChar))
                    {
                        result.Add(firstChar, secondChar);
                    }
                    else if (result[firstChar] != secondChar)
                    {
                        areExchang = false;
                        break;
                        
                    }
                }
            }
            else
            {
                for (int i = 0; i < Math.Min(firstTxt.Length,secondTxt.Length); i++)
                {
                    var firstChar = firstTxt[i];
                    var secondChar = secondTxt[i];
                    if (!result.ContainsKey(firstChar))
                    {
                        result.Add(firstChar, secondChar);
                    }
                    else if (result[firstChar] != secondChar)
                    {
                        areExchang = false;
                        break;
                    }
                }

                string bigger;
                string smaller;
                if (firstTxt.Length >= secondTxt.Length)
                {
                    bigger = firstTxt;
                    smaller = secondTxt;
                }
                else
                {
                    bigger = secondTxt;
                    smaller = firstTxt;
                }

                for (int i = 0; i < bigger.Length; i++)
                {
                    if (!result.ContainsValue(bigger[i]))
                    {
                        areExchang = false;
                    }
                   
                }

            }

            if (areExchang)
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
