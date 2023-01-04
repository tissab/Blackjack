using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blackjack.Tests.Step4
{
    [TestClass]
    public class Step4
    {
        [TestMethod]
        public void should_have_fifteen_when_cards_are_ten_and_four_and_ace()
        {
            ICard firstCard = new Card("10");
            ICard secondCard = new Card("4");
            ICard thirdCard = new Card("A");
            IHand hand = new Hand(firstCard, secondCard);

            hand.AddCard(thirdCard);

            Assert.AreEqual(15, hand.Points);
            Assert.IsFalse(hand.IsBusted);
        }

        [TestMethod]
        public void should_have_fourteen_when_cards_are_all_aces()
        {
            ICard firstCard = new Card("A");
            ICard secondCard = new Card("A");
            ICard thirdCard = new Card("A");
            ICard lastCard = new Card("A");
            IHand hand = new Hand(firstCard, secondCard);

            hand.AddCard(thirdCard);
            hand.AddCard(lastCard);

            Assert.AreEqual(14, hand.Points);
            Assert.IsFalse(hand.IsBusted);
        }

        [TestMethod]
        public void should_have_thirteen_when_cards_are_ace_and_ace_and_ace()
        {
            ICard firstCard = new Card("A");
            ICard secondCard = new Card("A");
            ICard thirdCard = new Card("A");
            IHand hand = new Hand(firstCard, secondCard);

            hand.AddCard(thirdCard);

            Assert.AreEqual(13, hand.Points);
            Assert.IsFalse(hand.IsBusted);
        }

        [TestMethod]
        public void should_have_twelve_when_cards_already_contains_As()
        {
            ICard firstCard = new Card("A");
            ICard secondCard = new Card("6");
            ICard thirdCard = new Card("4");
            ICard lastCard = new Card("A");
            IHand hand = new Hand(firstCard, secondCard);
            hand.AddCard(thirdCard);
            hand.AddCard(lastCard);
            Assert.AreEqual(12, hand.Points);
            Assert.IsFalse(hand.IsBusted);
        }

        [TestMethod]
        public void should_have_twenty_twi_and_busted_when_cards_are_ten_and_four_and_seven_and_ace()
        {
            ICard firstCard = new Card("10");
            ICard secondCard = new Card("4");
            ICard thirdCard = new Card("7");
            ICard fourthCard = new Card("A");
            IHand hand = new Hand(firstCard, secondCard);

            hand.AddCard(thirdCard);
            hand.AddCard(fourthCard);

            Assert.AreEqual(22, hand.Points);
            Assert.IsTrue(hand.IsBusted);
        }
    }

}
