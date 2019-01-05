using System;
using System.Collections.Generic;
using System.Text;
using ShedWebService.Domain.Entity;
using ShedWebService.Domain.Enums;

namespace ShedWebService.Domain.Extenders
{
    public static class CardExtender
    {
        public static bool IsAMagicCard(this Card card)
        {
            return card.Value.Equals(CardValue.Two) 
                || card.Value.Equals(CardValue.Three)
                || card.Value.Equals(CardValue.Seven)
                || card.Value.Equals(CardValue.Ten)
                || card.Value.Equals(CardValue.Ace);
        }

        public static bool CanBePlayedOn(this Card cardPlayed, List<Card> cardsOnPile)
        {
            Card topCardOnPile = cardsOnPile[-1];

            if (cardPlayed.IsAMagicCard())
            {
                return !topCardOnPile.Value.Equals(CardValue.Three); // Magic cards can be played on all cards except three
            }

            // Card played is not a magic card onwards
            if (topCardOnPile.IsAMagicCard())
            {
                switch (topCardOnPile.Value)
                {
                    case CardValue.Two:
                        return true;
                    case CardValue.Three:
                        return cardPlayed.CanBePlayedOn(cardsOnPile.GetRange(0, cardsOnPile.Count - 1));
                    case CardValue.Seven:
                        return (int) cardPlayed.Value < 7;
                    default:
                        return false; //Only Ace should be evaluated here
                }
            }

            // Neither are magic so just compare values
            return (int)cardPlayed.Value > (int)topCardOnPile.Value;
        }
    }
}
