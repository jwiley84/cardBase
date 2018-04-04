// Finally, create a class called "Player"

// Give the Player class a name property
// Give the Player a hand property that is a List of type Card
// Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card
// Note this method will require reference to a deck object
// Give the Player a discard method which discards the Card at the specified index from the player's hand and returns this Card or null if the index does not exist.


using System;
using System.Collections.Generic;

namespace cardDeck
{
    
    public class Player
    {
        public string name;

        List<Card> hand = new List<Card>();
        
        
        // public Player(List<Card> gameDeck) {
            // this.buildDeck();
            // this.

    // }
        public void showHand() {
            Console.WriteLine("The current hand is: ");
            Console.WriteLine("********************");
            foreach(Card item in hand) {
                // Console.WriteLine("The current hand is: ");
                Console.WriteLine(item.suitVal);
            }
        }
        public void draw(Deck gameDeck) {
            hand.Add(gameDeck.topCard()); //not sure about this one.
            // foreach (Card card in hand) {
                // Console.WriteLine("The card drawn was {0}", card.suitVal);
            // }
        }

        public Card discard(int cardNo) {
            Card discardCard = hand[cardNo];
            hand.RemoveAt(cardNo);
            
            return discardCard;
        }
    }

}