using System;
using System.Collections.Generic;
using System.Text;

namespace Kata20
{
    public static class CardsPack
    {
        private const Int32 numberCardInPack = 9;
        private const Int32 numberSuitInPack = 4;


        private static List<Card> cards = new List<Card>();
        public static IEnumerable<Card> Cards
        {
            get
            {
                return cards;
            }
        }

        public static Int32 CountCards
        {
            get
            {
                return cards.Count;
            }
        }


        public static void NewPack()
        {
            CleanCardsPack();
            GenerateNewPack();
        }
        private static void GenerateNewPack()
        {
            for (Int32 i = 0; i < numberSuitInPack; i++)
            {
                for (Int32 j = 0; j < numberCardInPack; j++)
                {
                    AddCardInCardsPack(i, j);
                }
            }
        }
        private static void AddCardInCardsPack(Int32 cardSuit, Int32 cardNumber)
        {
            cards.Add(
                new Card((CardSuit)cardSuit, (CardNumber)cardNumber)
                );
        }


        private static void CleanCardsPack()
        {
            cards.Clear();
        }


        public static void DeleteRangeCards(IEnumerable<Card> cards)
        {
            foreach (Card card in cards)
            {
                DeleteCard(card);
            }
        }

        public static Boolean DeleteCard(Card card)
        {
            return cards.Remove(card);
        }
    }
}
