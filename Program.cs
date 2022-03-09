using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    /// <summary>
    /// Exercise 9 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates using custom classes
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // create a new deck and tell the deck to print itself
            Console.WriteLine("Problem 1: Create a deck and tell it to print itself");
            Deck deck = new Deck();
            deck.Print();
            Console.WriteLine("=======================");

            // tell the deck to shuffle and print itself
            Console.WriteLine("Problem 2: Shuffle the deck and tell it to print itself");
            deck.Shuffle();
            Console.WriteLine("The deck was shuffled.");
            Console.WriteLine("=======================");
            deck.Print();
            Console.WriteLine("The reshuffled deck was printed.");
            Console.WriteLine("=======================");

            // take two cards from the top of the deck and print the cards' rank and suit
            Console.WriteLine("Problem 3 - Take two cards from the top of the deck and print their rank and suit.");
            Card card1 = deck.TakeTopCard();
            Card card2 = deck.TakeTopCard();
            Console.WriteLine("First card from the deck is : " + card1.Rank + " of " + card1.Suit);
            Console.WriteLine("Second card from the deck is : " + card2.Rank + " of " + card2.Suit);
            Console.WriteLine("=======================");
            Console.Write("Hit enter key to exit game.");

            Console.ReadLine(); // pause window to stay visible until pressing the enter key to close it down
        }
    }
}
