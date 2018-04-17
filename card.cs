namespace Deck_of_Cards {
    public class Card {
        public string stringVal;
        public string suit;
        public int val;
        public Card(string cSuit, int cVal, string cStringVal){
            suit = cSuit;
            val = cVal;
            stringVal = cStringVal;
        }
    }
}