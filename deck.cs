using System;
using System.Collections.Generic;

namespace Deck_of_Cards {
    public class Deck {
        public List<Card> cards;

        // Creates a new deck when creating a deck in the program file.
        public Deck(){
            newDeck();
        }

        // Creates a deck containing a card of each suit and value | Private so it is only accessable from here
        private void newDeck(){
            cards = new List<Card>();
            string[] suits = {"Clubs", "Spades", "Hearts", "Diamonds"};
            string[] stringVals = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            foreach (string suit in suits){
                for (int i = 0; i < stringVals.Length; i++){
                    cards.Add(new Card(suit, i+1, stringVals[i]));
                }
            }
        }
        public void shuffle(){
            Random rand = new Random();
            for(int i = 0; i < cards.Count - 1; i++){
                int randidx = rand.Next(i + 1, cards.Count);
                Card temp = cards[i];
                cards[i] = cards[randidx];
                cards[randidx] = temp;
            }
        }
        public Card deal(){
            Card dealt = cards[0];
            // Console.WriteLine(cards[0].stringVal + " of " + cards[0].suit + " delt.");
            cards.RemoveAt(0);
            return dealt;
        }
        public void reset(){
            cards.Clear();
            string[] suits = {"Clubs", "Spades", "Hearts", "Diamonds"};
            string[] stringVals = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            foreach (string suit in suits){
                for (int i = 0; i < stringVals.Length; i++){
                    cards.Add(new Card(suit, i+1, stringVals[i]));
                }
            }
        }
    }
}