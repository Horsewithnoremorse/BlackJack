using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            CartDeck deck = new CartDeck();
            deck.CreateDeck();
            deck.PrintDeck();
            
        }
    }
}
