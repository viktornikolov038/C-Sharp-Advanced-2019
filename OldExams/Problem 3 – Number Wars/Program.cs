using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Number_Wars
{
    public class Program
    {
        public static void Main()
        {
            var firstHandInput = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var secondHandInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var firstHand = new Queue<string>(firstHandInput);
            var secondHand = new Queue<string>(secondHandInput);

            var turns = 0;
            while (firstHand.Any() && secondHand.Any() && turns < 1000000)
            {
                turns++;

                var firstHandNum = int.Parse(firstHand.Peek().Substring(0, firstHand.Peek().Length - 1));
                var secondHandNum = int.Parse(secondHand.Peek().Substring(0, secondHand.Peek().Length - 1));
                if (firstHandNum > secondHandNum)
                {
                    var winnerCards = new List<string>()
                    {
                        firstHand.Dequeue(),
                        secondHand.Dequeue()
                    };

                    winnerCards = winnerCards.OrderByDescending(a => a).ToList();
                    for (int i = 0; i < winnerCards.Count; i++)
                    {
                        firstHand.Enqueue(winnerCards[i]);
                    }
                }else if (secondHandNum > firstHandNum)
                {
                    var winnerCards = new List<string>()
                    {
                        firstHand.Dequeue(),
                        secondHand.Dequeue()
                    };

                    winnerCards = winnerCards.OrderByDescending(a => a).ToList();
                    for (int i = 0; i < winnerCards.Count; i++)
                    {
                        secondHand.Enqueue(winnerCards[i]);
                    }
                }
                else
                { 
                    Checker:
                    if (!firstHand.Any())
                    {
                        break;
                    }
                    else if (!secondHand.Any())
                    {
                        break;
                    }
                    var FirstdrawCard = firstHand.Dequeue();
                    var SecondrawCard = secondHand.Dequeue();
                    var firstCardsDrawSum = new List<string>();
                    var secondCardsDrawSum = new List<string>();
                    for (int i = 0; i < Math.Min(3,firstHand.Count); i++)
                    {
                        firstCardsDrawSum.Add(firstHand.Dequeue());
                    }

                    for (int i = 0; i < Math.Min(3, secondHand.Count); i++)
                    {
                        secondCardsDrawSum.Add(secondHand.Dequeue());
                    }
                    var FirstCardslettersSum = 0;
                    foreach (var card in firstCardsDrawSum)
                    {
                        var letter = card[card.Length - 1];
                        if (char.IsLower(letter))
                        {
                            FirstCardslettersSum += (int)letter - 96;
                        }
                        else
                        {
                            FirstCardslettersSum += (int)letter - 64;
                        }
                    }

                    var SecondCardslettersSum = 0;
                    foreach (var card in secondCardsDrawSum)
                    {
                        var letter = card[card.Length - 1];
                        if (char.IsLower(letter))
                        {
                            SecondCardslettersSum += (int)letter - 96;
                        }
                        else
                        {
                            SecondCardslettersSum += (int)letter - 64;
                        }
                    }

                    if (FirstCardslettersSum > SecondCardslettersSum)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            firstHand.Dequeue();
                        }

                        var winnerAdd = firstCardsDrawSum.Concat(secondCardsDrawSum).ToList().OrderByDescending(a => a).ToList();

                        for (int i = 0; i < winnerAdd.Count(); i++)
                        {
                            firstHand.Enqueue(winnerAdd[i]);
                        }
                    }
                    else if(SecondCardslettersSum > FirstCardslettersSum)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            secondHand.Dequeue();
                        }

                        var winnerAdd = firstCardsDrawSum.Concat(secondCardsDrawSum).ToList().OrderByDescending(a => a).ToList();

                        for (int i = 0; i < winnerAdd.Count(); i++)
                        {
                            secondHand.Enqueue(winnerAdd[i]);
                        }
                    }
                    else
                    {
                        goto Checker;
                    }
                }

            }
            if (firstHand.Any() && turns < 1000000)
            {
                Console.WriteLine($"First player wins after {turns} turns");
            }
            else if(secondHand.Any() && turns < 1000000)
            {
                Console.WriteLine($"Second player wins after {turns} turns");
            }
            else
            {
                if (firstHand.Count > secondHand.Count)
                {
                    Console.WriteLine($"First player wins after {turns} turns");
                }
                else if(secondHand.Count > firstHand.Count)
                {
                    Console.WriteLine($"Second player wins after {turns} turns");
                }
                else
                {
                    Console.WriteLine($"Draw after {turns} turns");
                }
            }

        }
    }
}
