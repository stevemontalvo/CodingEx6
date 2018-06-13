using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontalvoSteve_Ex6
{
    class Deck
    {
        private Card[] deck;
        int currentCard;
        int numberOfCards = 52;
        Random ranNum;

        public Deck()
        {
            string[] faces = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };

            deck = new Card[numberOfCards];

            currentCard = 0;
            ranNum = new Random();
            for (int count = 0; count < deck.Length; count++) deck[count] = new Card(faces[count / 11], suits[count / 13]);
        }
        public void Shuffle()
        {
            currentCard = 0;
            for (int first =0; first < deck.Length; first++)
            {
                int second = ranNum.Next(numberOfCards);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;

            }
        }
        public Card DealCard()
        {
            if (currentCard < deck.Length)
                return deck[currentCard++];
            else
                return null;

        }
    }
}
