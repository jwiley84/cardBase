using System;

namespace cardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck testDeck = new Deck();
            // Console.WriteLine("Run after deck is built");
            // Console.WriteLine("********************");
            // testDeck.bugCheck();
            // Console.WriteLine("********************");
            // Console.WriteLine("Reset Deck:");
            // Console.WriteLine("********************");
            // testDeck.reset();
            // testDeck.bugCheck();
            // Console.WriteLine("********************");
            // testDeck.shuffle();
            // testDeck.bugCheck();
            Console.WriteLine("********************");
            testDeck.shuffle();
            // testDeck.topCard();
            Console.WriteLine("********************");
            Player p1 = new Player();
            testDeck.topFive();
            p1.draw(testDeck);
            // testDeck.topFive();
            p1.draw(testDeck);
            p1.draw(testDeck);
            p1.showHand();
            // testDeck.topFive();
            p1.discard(0);
            p1.showHand();
        }
    }
}
