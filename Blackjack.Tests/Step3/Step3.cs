using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blackjack.Tests.Step3
{
    [TestClass]
    public class Step3
    {
        [TestMethod]
        public void should_be_busted_when_score_goes_above_21()
        {
            ICard firstCard = new Card("10");
            ICard secondCard = new Card("10");
            ICard thirdCard = new Card("2");
            IHand hand = new Hand(firstCard, secondCard);

            hand.AddCard(thirdCard);
            Assert.IsFalse(hand.IsBlackjack);
            Assert.IsTrue(hand.IsBusted);
        }

        [TestMethod]
        public void should_have_blackjack_when_cards_are_ace_and_ten()
        {
            ICard firstCard = new Card("A");
            ICard secondCard = new Card("10");
            IHand hand = new Hand(firstCard, secondCard);

            Assert.AreEqual(21, hand.Points);
            Assert.IsTrue(hand.IsBlackjack);
            Assert.IsFalse(hand.IsBusted);
        }

        [TestMethod]
        public void should_not_have_blackjack_when_cards_are_ace_and_eight()
        {
            ICard firstCard = new Card("A");
            ICard secondCard = new Card("8");
            IHand hand = new Hand(firstCard, secondCard);

            Assert.AreEqual(19, hand.Points);
            Assert.IsFalse(hand.IsBlackjack);
            Assert.IsFalse(hand.IsBusted);
        }

        [TestMethod]
        public void should_not_have_blackjack_when_cards_are_ace_and_six_and_four()
        {
            ICard firstCard = new Card("A");
            ICard secondCard = new Card("6");
            ICard thirdCard = new Card("4");
            IHand hand = new Hand(firstCard, secondCard);

            hand.AddCard(thirdCard);

            Assert.AreEqual(21, hand.Points);
            Assert.IsFalse(hand.IsBlackjack);
            Assert.IsFalse(hand.IsBusted);
        }
    }

}
