using System;
using System.Collections.Generic;
using System.Text;

namespace Kata20
{
    public class Card
    {
        private readonly CardSuit suit;
        public CardSuit Suit
        {
            get
            {
                return suit;
            }
        }

        private readonly CardNumber number;
        public CardNumber Number
        {
            get
            {
                return number;
            }
        }

        public Card(CardSuit suit, CardNumber number)
        {
            this.suit = suit;
            this.number = number;
        }

        public override Boolean Equals(Object obj)
        {
            Card card = obj as Card;

            if(card == null)
            {
                return false;
            }
            if (card.Number == this.Number & card.Suit == this.Suit)
            {
                return true;
            }
            return false;
        }

        public override Int32 GetHashCode()
        {
            return (Int32)Suit * 3 + (Int32)Number * 6;
        }
    }
}
