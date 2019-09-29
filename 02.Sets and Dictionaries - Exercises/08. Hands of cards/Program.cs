using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Hands_of_cards
{
    public class Program
    {
        public static void Main()
        {
            var playerAndCards = new Dictionary<string,HashSet<string>>();
            while (true)
            {
                
                var inputLine = Console.ReadLine();
                if (inputLine == "JOKER")
                {
                    break;
                }

                var tokens = inputLine.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                var currentPlayer = tokens[0];
                var currentPlayerCards = tokens[1].Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);
                if (!playerAndCards.ContainsKey(currentPlayer))
                {
                    playerAndCards[currentPlayer] = new HashSet<string>();
                }
                for (int i = 0; i < currentPlayerCards.Length; i++)
                {
                    playerAndCards[currentPlayer].Add(currentPlayerCards[i]);
                }
            }

            

            foreach (var kvp in playerAndCards)
            {
                var currentCardPoints = 0;

                var currentCards = kvp.Value;
                var currentPlayer = kvp.Key;
                foreach (var card in currentCards)
                {
                    if (char.IsDigit(card[0]) && card.Length != 3)
                    {
                        currentCardPoints = cardColor(currentCardPoints, card);
                    }
                    else if (card.Length != 3)
                    {
                        switch (card[0])
                        {
                            case 'J':

                                if (card[1] == 'S')
                                {
                                    currentCardPoints += 11 * 4;
                                }else if (card[1] == 'H')
                                {
                                    currentCardPoints += 11 * 3;
                                }else if (card[1] == 'D')
                                {
                                    currentCardPoints += 11 * 2;
                                }else if (card[1] == 'C')
                                {
                                    currentCardPoints += 11 * 1;
                                }
                                break;
                            case 'Q':

                                if (card[1] == 'S')
                                {
                                    currentCardPoints += 12 * 4;
                                }
                                else if (card[1] == 'H')
                                {
                                    currentCardPoints += 12 * 3;
                                }
                                else if (card[1] == 'D')
                                {
                                    currentCardPoints += 12 * 2;
                                }
                                else if (card[1] == 'C')
                                {
                                    currentCardPoints += 12 * 1;
                                }
                                break;
                            case 'K':

                                if (card[1] == 'S')
                                {
                                    currentCardPoints += 13 * 4;
                                }
                                else if (card[1] == 'H')
                                {
                                    currentCardPoints += 13 * 3;
                                }
                                else if (card[1] == 'D')
                                {
                                    currentCardPoints += 13 * 2;
                                }
                                else if (card[1] == 'C')
                                {
                                    currentCardPoints += 13 * 1;
                                }
                                break;
                            case 'A':

                                if (card[1] == 'S')
                                {
                                    currentCardPoints += 14 * 4;
                                }
                                else if (card[1] == 'H')
                                {
                                    currentCardPoints += 14 * 3;
                                }
                                else if (card[1] == 'D')
                                {
                                    currentCardPoints += 14 * 2;
                                }
                                else if (card[1] == 'C')
                                {
                                    currentCardPoints += 14 * 1;
                                }
                                break;

                        }
                    }
                    else
                    {
                        if (card[2] == 'S')
                        {
                            currentCardPoints += 10 * 4;
                        }
                        else if (card[2] == 'H')
                        {
                            currentCardPoints += 10 * 3;
                        }
                        else if (card[2] == 'D')
                        {
                            currentCardPoints += 10 * 2;
                        }
                        else if (card[2] == 'C')
                        {
                            currentCardPoints += 10 * 1;
                        }
                    }


                }
                Console.WriteLine($"{currentPlayer}: {currentCardPoints}");
            }
        }

        private static int cardColor(int currentCardPoints, string card)
        {
            switch (card[1])
            {
                case 'S':
                    currentCardPoints += int.Parse(card[0].ToString()) * 4;
                    break;
                case 'H':
                    currentCardPoints += int.Parse(card[0].ToString()) * 3;
                    break;
                case 'D':
                    currentCardPoints += int.Parse(card[0].ToString()) * 2;
                    break;
                case 'C':
                    currentCardPoints += int.Parse(card[0].ToString()) * 1;
                    break;
            }

            return currentCardPoints;
        }
    }
}



