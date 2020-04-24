using Kata20;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Kata20Tests
{
    [TestClass]
    public class CardsPackTests
    {
        [TestMethod]
        public void CreateCardsPackTest()
        {
            CardsPack.NewPack();

            Assert.AreEqual(36, CardsPack.CountCards);
        }


        [TestMethod]
        public void DifferentSuitsCreateNeededCountCardsTest()
        {
            Int32 countHeartCard = 0, countDiamondCard = 0,
                countClubCard = 0, countSpadeCard = 0;

            CardsPack.NewPack();
            IEnumerable<Card> cards = CardsPack.Cards;

            foreach (Card card in cards)
            {
                if (card.Suit == CardSuit.Heart)
                    countHeartCard++;
                if (card.Suit == CardSuit.Diamond)
                    countDiamondCard++;
                if (card.Suit == CardSuit.Club)
                    countClubCard++;
                if (card.Suit == CardSuit.Spade)
                    countSpadeCard++;
            }

            Assert.AreEqual(9, countHeartCard);
            Assert.AreEqual(9, countDiamondCard);
            Assert.AreEqual(9, countClubCard);
            Assert.AreEqual(9, countSpadeCard);
        }

        [TestMethod]
        public void NumberCreateNeededCountCardsTest()
        {
            Int32 countSix = 0, countSeven = 0, countEight = 0,
                countNine = 0, countTen = 0, countJack = 0,
                countLady = 0, countKing = 0, countAce = 0;

            CardsPack.NewPack();
            IEnumerable<Card> cards = CardsPack.Cards;

            foreach (Card card in cards)
            {
                if (card.Number == CardNumber.Six)
                    countSix++;
                if (card.Number == CardNumber.Seven)
                    countSeven++;
                if (card.Number == CardNumber.Eight)
                    countEight++;
                if (card.Number == CardNumber.Nine)
                    countNine++;
                if (card.Number == CardNumber.Ten)
                    countTen++;
                if (card.Number == CardNumber.Jack)
                    countJack++;
                if (card.Number == CardNumber.Lady)
                    countLady++;
                if (card.Number == CardNumber.King)
                    countKing++;
                if (card.Number == CardNumber.Ace)
                    countAce++;
            }

            Assert.AreEqual(4, countSix);
            Assert.AreEqual(4, countSeven);
            Assert.AreEqual(4, countEight);
            Assert.AreEqual(4, countNine);
            Assert.AreEqual(4, countTen);
            Assert.AreEqual(4, countJack);
            Assert.AreEqual(4, countLady);
            Assert.AreEqual(4, countKing);
            Assert.AreEqual(4, countAce);
        }

        [TestMethod]
        public void DeleteCardFromCardsPack()
        {
            Card cardForDelete = new Card(CardSuit.Heart, CardNumber.Jack);

            CardsPack.NewPack();

            Boolean statusDeletingExistCard =
                CardsPack.DeleteCard(cardForDelete);

            Boolean statusDeletingNotExistCard =
                CardsPack.DeleteCard(cardForDelete);

            Assert.AreEqual(true, statusDeletingExistCard);
            Assert.AreEqual(false, statusDeletingNotExistCard);
            Assert.AreEqual(35, CardsPack.CountCards);
        }

        [TestMethod]
        public void DeleteRangeCardsFromCardsPack()
        {
            List<Card> cards = new List<Card>()
            {
                new Card(CardSuit.Heart, CardNumber.Jack),
                new Card(CardSuit.Spade, CardNumber.Six),
                new Card(CardSuit.Diamond, CardNumber.Ace)
            };

            CardsPack.NewPack();

            CardsPack.DeleteRangeCards(cards);
            CardsPack.DeleteRangeCards(cards);

            Assert.AreEqual(33, CardsPack.CountCards);
        }


    }
}
