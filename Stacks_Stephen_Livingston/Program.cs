using System;
using System.Collections.Generic;



namespace Stacks_Stephen_Livingston
{
    class Program
    {
        static void Main(string[] args)
        {
            Card[] myCardsArray = new Card[] // creates card array with card objects.
            {
                new Card("Ace", "Spades"),
                new Card("Jack", "Clubs"),
                new Card("Queen", "Diamonds"),
                new Card("Queen", "Diamonds"),
                new Card("10", "Hearts"),
                new Card("2", "Diamonds"),
                new Card("6", "Spades"),
                new Card("9", "Clubs"),
                new Card("Ace", "Diamonds")
            };

            Stack<Card> startingDeck = new Stack<Card>(myCardsArray); // creates a stack that the cards are pushed through.

            Console.WriteLine("Cards in Deck:"); // prints to the console and loops through the stack.
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

            Console.WriteLine($"Cards in the stack: {startingDeck.Count}"); // prints the number of cards in the stack.

            List<Card> myHand = new List<Card>(); // creates new card list called myHand and adds 3 cards to myHand
            myHand.Add(new Card("Jack", "Diamonds"));
            myHand.Add(new Card("8", "Hearts"));
            myHand.Add(new Card("3", "Diamonds"));

            Console.WriteLine("Got any 8's?"); // Prints to the console a question and adds a card if the startingDeck count is 0.
            if(startingDeck.Count > 0)
            {
                myHand.Add(startingDeck.Pop());
            }

            Console.WriteLine($"Cards in the stack: {startingDeck.Count}"); // prints how many cards a re in the deck to the console.

            startingDeck.Push(myHand[0]); // places one of the cards in your hand on the stack.
            myHand.RemoveAt(0); // removes the card placed from your hand.

            Console.WriteLine("Cards in Deck:"); // prints the cards in the deck to the console.
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!"); // loops through the stack and prints on a new line for each card.
            }

        }
    }
}
