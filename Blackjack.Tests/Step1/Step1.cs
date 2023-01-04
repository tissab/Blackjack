using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blackjack.Tests.Step1
{
    [TestClass]
    public class Step1
    {
        [TestMethod]
        public void should_value_eleven_when_card_displays_ace()
        {
            ICard card = new Card("A");

            Assert.AreEqual(11, card.Points);
        }

        [TestMethod]
        public void should_value_seven_when_card_displays_two()
        {
            ICard card = new Card("7");

            Assert.AreEqual(7, card.Points);
        }

        [TestMethod]
        public void should_value_ten_when_card_displays_jack()
        {
            ICard card = new Card("J");

            Assert.AreEqual(10, card.Points);
        }

        [TestMethod]
        public void should_value_ten_when_card_displays_king()
        {
            ICard card = new Card("K");

            Assert.AreEqual(10, card.Points);
        }

        [TestMethod]
        public void should_value_ten_when_card_displays_queen()
        {
            ICard card = new Card("Q");

            Assert.AreEqual(10, card.Points);
        }

        [TestMethod]
        public void should_value_ten_when_card_displays_two()
        {
            ICard card = new Card("10");

            Assert.AreEqual(10, card.Points);
        }

        [TestMethod]
        public void should_value_two_when_card_displays_two()
        {
            ICard card = new Card("2");

            Assert.AreEqual(2, card.Points);
        }
    }

}
