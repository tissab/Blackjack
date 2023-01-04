namespace Blackjack
{
    public interface IHand
    {
        bool IsBlackjack { get; }
        bool IsBusted { get; }
        int Points { get; }

        void AddCard(ICard card);
    }

}
