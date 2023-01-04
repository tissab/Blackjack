using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blackjack.Tests.Step2
{
    [TestClass]
    public class Step2
    {
        [TestMethod]
        public void should_have_four_points_when_cards_are_two_and_two()
        {
            ICard firstCard = new Card("2");
            ICard secondCard = new Card("2");
            IHand hand = new Hand(firstCard, secondCard);

            Assert.AreEqual(4, hand.Points);
        }

        [TestMethod]
        public void should_have_fourteen_points_when_cards_are_eight_and_six()
        {
            ICard firstCard = new Card("8");
            ICard secondCard = new Card("6");
            IHand hand = new Hand(firstCard, secondCard);

            Assert.AreEqual(14, hand.Points);
        }

        [TestMethod]
        public void should_have_nineteen_points_when_cards_are_eight_and_six_and_five()
        {
            ICard firstCard = new Card("8");
            ICard secondCard = new Card("6");
            ICard thirdCard = new Card("5");
            IHand hand = new Hand(firstCard, secondCard);

            hand.AddCard(thirdCard);

            Assert.AreEqual(19, hand.Points);
        }

        [TestMethod]
        public void should_have_seventeen_points_when_cards_are_four_and_five_and_two_and_six()
        {
            ICard firstCard = new Card("4");
            ICard secondCard = new Card("5");
            ICard thirdCard = new Card("2");
            ICard fourthCard = new Card("6");

            IHand hand = new Hand(firstCard, secondCard);

            hand.AddCard(thirdCard);
            hand.AddCard(fourthCard);

           Assert.AreEqual(17, hand.Points);
        }
    }

}
