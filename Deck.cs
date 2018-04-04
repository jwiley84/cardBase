// Next, create a class called "Deck"

// Give the Deck class a property called "cards" which is a list of 
// Card objects
// When initializing the deck make sure that it has a list of 52 
// unique cards as its "cards" property
// Give the Deck a reset method that resets the cards property to 
// the contain the original 52 cards

// Give the Deck a deal method that selects the "top-most" card, 
// removes it from the list of cards, and returns the Card
// Give the Deck a shuffle method that randomly reorders the deck's 
// cards

using System;
using System.Collections.Generic;

namespace cardDeck
{
    
    public class Deck
    {
        List<Card> cards = new List<Card>();
        
        public Deck() {
            this.buildDeck();

        }
        public void buildDeck() {
            string[] suits = {"Hearts", "Diamonds", "Spades", "Clubs"};
            for (int i = 1; i <= 13; i++) {
                for (int j = 0; j < suits.Length; j++) {
                    cards.Add(new Card(suits[j], i));
                }
            }
        }

        public void reset() {
            cards.Clear(); 
            this.buildDeck();
        }
        public void bugCheck() {
            foreach (Card item in cards) {
                Console.WriteLine(item.suitVal);
            }
        }
        public void shuffle() {
            int seed;
            Random rand = new Random();
            int deckCount = cards.Count;
            
            while (deckCount > 1) {
                deckCount--;
                seed = rand.Next(deckCount + 1);
                Card split = cards[seed];
                cards[seed] = cards[deckCount];
                cards[deckCount] = split;
            }
        }

        public Card topCard() {
            // Console.WriteLine("Top card before deal is the {0}",cards[0].suitVal);
            Card temp = cards[0];
            cards.RemoveAt(0);
            // Console.WriteLine("Dealt card is the {0}", temp.suitVal);
            // Console.WriteLine("Top card after deal is the {0}",cards[0].suitVal);
            return temp;
        }

        public void topFive() {
            Console.WriteLine("********************");
            Console.WriteLine("The top 5 cards in the deck are: ");
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(cards[i].suitVal);
            }
        Console.WriteLine("********************");   
    }
}
}
