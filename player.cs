using System;
using System.Collections.Generic;

namespace Deck_of_Cards {
    public class Player {
        public string name;
        public Player(string pName = "Cowboy"){
            name = pName;
        }
        public List<Card> hand = new List<Card>();

        public Card draw(Deck target)
        {
            Card newCard = target.deal();
            // Console.WriteLine(newCard.stringVal + " of " + newCard.suit + " drawn.");
            hand.Add(newCard);
            return newCard;
        }

        public void discard(int target) {

            Card discarded = hand[target-1] as Card;
            if(discarded != null) {
                Console.WriteLine(discarded.stringVal + " of " + discarded.suit + " discarded.");
                hand.RemoveAt(target-1);
            } else {
                Console.WriteLine("No card to discard there.");
            }
        }
    }
}