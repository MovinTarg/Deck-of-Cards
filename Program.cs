using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Deck num1 = new Deck();
            Player Blue = new Player("Blue");
            Console.WriteLine(Blue.name);
            // for (int i = 0; i < num1.cards.Count; i++){
            //     Console.WriteLine(num1.cards[i].stringVal);
            //     Console.WriteLine(num1.cards[i].suit);
            //     Console.WriteLine("----------");
            // }
            // Console.WriteLine(num1.cards.Count);
            // Console.WriteLine("----------");
            // Console.WriteLine("----------");
            num1.shuffle();
            // for (int i = 0; i < num1.cards.Count; i++){
            //     Console.WriteLine(num1.cards[i].stringVal);
            //     Console.WriteLine(num1.cards[i].suit);
            //     Console.WriteLine("----------");
            // }
            // Console.WriteLine(num1.cards.Count);
            // Console.WriteLine("----------");
            // Console.WriteLine("----------");
            // num1.deal();
            // Console.WriteLine(num1.cards.Count);
            // Console.WriteLine("----------");
            // num1.deal();
            // Console.WriteLine(num1.cards.Count);
            // Console.WriteLine("----------");
            // num1.reset();
            // Console.WriteLine(num1.cards.Count);
            // Console.WriteLine("----------");
            Blue.draw(num1);
            Blue.draw(num1);
            Blue.draw(num1);
            Blue.draw(num1);
            Blue.draw(num1);
            for (int i = 0; i < Blue.hand.Count; i++){
                Console.WriteLine(Blue.hand[i].stringVal);
                Console.WriteLine(Blue.hand[i].suit);
                Console.WriteLine("----------");
            }
            Console.WriteLine(Blue.hand.Count);
            Blue.discard(3);
            for (int i = 0; i < Blue.hand.Count; i++){
                Console.WriteLine(Blue.hand[i].stringVal);
                Console.WriteLine(Blue.hand[i].suit);
                Console.WriteLine("----------");
            }
            Console.WriteLine(Blue.hand.Count);
        }
    }
}
