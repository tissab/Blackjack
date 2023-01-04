using System.Linq;

namespace Blackjack
{
    public class Hand : IHand
    {
        private readonly List<ICard> cards;
        private readonly ICard firsCard;
        private readonly ICard secondCard;
        private bool isAce = false;

        public Hand(ICard firsCard, ICard secondCard)
        {
            this.firsCard = firsCard;
            this.secondCard = secondCard;
            cards = new List<ICard>();
            cards.Add(firsCard);
            cards.Add(secondCard);
        }

        public bool IsBlackjack 
        { 
            get
            {
                if(cards.Count == 2)
                {
                    if (Points == 21) 
                        return true;
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsBusted
        {
            get => Points > 21;
        }

        public int Points
        {
            get 
            { 
                if(cards.Count() <= 2)
                {
                    return cards.Select(x => x.Points).Sum(); 
                }
                else
                {
                   if( cards.Where(x => !x.Value.Equals("A")).Count() > 1)
                   {
                     if(cards.Where(x => !x.Value.Equals("A")).Select(x => x.Points).Sum() == 10 && cards.Where(x => x.Value.Equals("A")).Count() == 1)
                     {
                       return cards.Select(x => x.Points).Sum();
                     }
                      return cards.Where(x => !x.Value.Equals("A")).Select(x => x.Points).Sum() + cards.Where(x => x.Value.Equals("A")).Count();
                   }

                    return (
                        cards.Where(x => !x.Value.Equals("A")).Select(x => x.Points).ToList().Sum() + 
                         cards.Where(x => x.Value.Equals("A")).Count() + 10
                        ); 
                  
                }
            } 
        }

        public void AddCard(ICard card)
        {
            cards.Add(card);
        }
    }

}
