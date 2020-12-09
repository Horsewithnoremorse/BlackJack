using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    class CartDeck
    {
        string[] Suits = { "♥", "♦", "♣", "♠" };
        string[] Ranks = { " 2", " 3", " 4", " 5", " 6", " 7", " 8", " 9", "10", " J", " Q", " K", " A" };
        int[] Values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };
        List<Card> NewDeck = new List<Card>();

        public void CreateDeck ()
        {
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    NewDeck.Add(new Card());
                    NewDeck[index].Suit = Suits[i];
                    NewDeck[index].Rank = Ranks[j];
                    NewDeck[index].Value = Values[j];
                    index++;
                }
            }
        }

        public void PrintDeck ()
        {
            for (int i=0; i < NewDeck.Count; i++)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("_________________");
                Console.WriteLine("|               |");
                Console.WriteLine($"|  {NewDeck[i].Rank}{NewDeck[i].Suit}          |");
                Console.WriteLine("|               |");
                Console.WriteLine("|               |");
                Console.WriteLine("|               |");
                Console.WriteLine("|               |");
                Console.WriteLine($"|          {NewDeck[i].Rank}{NewDeck[i].Suit}  |");
                Console.WriteLine("|               |");
                Console.WriteLine("‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾");
            }
            Console.WriteLine("пики (♠), червы (♥), бубны (♦) и трефы (♣).");
            
        }
    }
}
